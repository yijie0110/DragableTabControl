﻿using DragableTabControl.ViewModels;
using Dragablz;
using Prism.Events;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DragableTabControl.Extensions
{
    public class TabControlAdapter : RegionAdapterBase<TabablzControl>
    {
        public const string BehaviorKey = "DragablzWindowBehavior";

        private TabablzControl activeWindow;
        private readonly ObservableCollection<TabablzControl> windows;
        private readonly Dictionary<object, TabClientProxy> itemToTabClientMapping;
        private IRegion Region;

        public TabControlAdapter(IRegionBehaviorFactory regionBehaviorFactory, IContainerProvider containerProvider) : base(regionBehaviorFactory)
        {
            this.windows = new ObservableCollection<TabablzControl>();
            this.itemToTabClientMapping = new Dictionary<object, TabClientProxy>();
        }


        public void OnDragablzWindowEvent(DragablzWindowEventArgs args)
        {
            switch (args.Type)
            {
                case DragablzWindowEventType.Opened:
                    OnWindowOpened(args.TabControl);
                    break;

                case DragablzWindowEventType.Closed:
                    OnWindowClosed(args.TabControl);
                    break;

                case DragablzWindowEventType.Activated:
                    OnWindowActivated(args.TabControl);
                    break;
            }
        }

        private void OnWindowActivated(TabablzControl tabControl)
        {
            if (this.activeWindow != tabControl)
            {
                SetActiveView(tabControl);
            }
        }

        private void OnWindowClosed(TabablzControl tabControl)
        {
            ClearRelatedTabs(tabControl);
            this.windows.Remove(tabControl);
            tabControl.SelectionChanged -= TabControl_SelectionChanged;

            if (this.activeWindow == tabControl)
            {
                this.activeWindow = this.windows.FirstOrDefault();
            }
        }

        private void ClearRelatedTabs(TabablzControl tabControl)
        {
            var items = tabControl.Items.OfType<TabClientProxy>().ToList();

            items.ForEach(item =>
            {
                try
                {
                    this.Region.Remove(item.Content);
                }
                catch (ArgumentException) { }
            });
        }

        private void OnWindowOpened(TabablzControl tabControl)
        {
            this.activeWindow = tabControl;
            this.windows.Add(tabControl);
            tabControl.ClosingItemCallback = ClosingItemCallback;
            tabControl.SelectionChanged += TabControl_SelectionChanged;
        }

        private void TabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                var item = e.AddedItems[0] as TabClientProxy;
                if (item != null)
                {
                    var regionItem = item.Content;

                    if (this.Region.Views.Contains(regionItem))
                    {
                        this.Region.Activate(regionItem);
                    }
                }
            }
        }


        private void ClosingItemCallback(ItemActionCallbackArgs<TabablzControl> args)
        {
            // remove from region
            this.Region.Remove(((TabClientProxy)args.DragablzItem.DataContext).Content);
        }

        private void ActiveViews_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    ActivateView(e.NewItems[0]);

                    break;
            }
        }

        private void Views_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    AddView(e.NewItems[0]);
                    break;

                case NotifyCollectionChangedAction.Remove:
                    RemoveView(e.OldItems[0]);
                    break;
            }
        }

        private void ActivateView(object view)
        {
            var proxy = GetProxy(view);
            var window = GetWindow(view);

            //Debug.WriteLine($"Activating {proxy.CommonData.Title}");

            if (window.SelectedItem != proxy || window != this.activeWindow)
            {
                window.SelectedItem = proxy;
                window.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
            }
        }

        private void SetActiveView(TabablzControl window)
        {
            if (this.activeWindow != window)
            {
                this.activeWindow = window;
                this.activeWindow.BringIntoView();
                this.activeWindow.Focus();

                var view = this.activeWindow.SelectedItem as TabClientProxy;
                if (view != null && this.Region.Views.Contains(view.Content))
                {
                    this.Region.Activate(view.Content);
                }
            }
        }

        private void RemoveView(object view)
        {
            var window = GetWindow(view);
            var proxy = GetProxy(view);
            window.Items.Remove(proxy);

            CleanUp(view);
        }

        private void CleanUp(object view)
        {
            this.itemToTabClientMapping.Remove(view);
        }

        private void AddView(object view)
        {
            this.activeWindow.Items.Add(CreateProxy(view));
        }

        private TabablzControl GetWindow(object view)
        {
            var proxy = GetProxy(view);

            foreach (var window in this.windows)
            {
                if (ContainsView(window, proxy))
                {
                    return window;
                }
            }

            return null;
        }

        private bool ContainsView(TabablzControl window, TabClientProxy proxy)
        {
            if (proxy == null || window == null) return false;

            return window.Items.OfType<TabClientProxy>().Any(tc => tc == proxy);
        }

        private TabClientProxy GetProxy(object view)
        {
            return this.itemToTabClientMapping[view];
        }

        private TabClientProxy CreateProxy(object view)
        {
            var proxy = new TabClientProxy
            {
                Content = view,
                CommonData = RegionUtility.GetInterfaceFromView<ViewModelBase>(view)
            };

            this.itemToTabClientMapping.Add(view, proxy);

            return proxy;
        }

        protected override void Adapt(IRegion region, TabablzControl regionTarget)
        {
            this.Region = region;
            region.Views.CollectionChanged += Views_CollectionChanged;
            region.ActiveViews.CollectionChanged += ActiveViews_CollectionChanged;

            var eventAggregator = ContainerLocator.Current.Resolve<IEventAggregator>();
            eventAggregator.GetEvent<DragablzWindowEvent>().Subscribe(OnDragablzWindowEvent);
        }

        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }
}
