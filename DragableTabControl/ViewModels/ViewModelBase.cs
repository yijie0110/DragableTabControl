using DragableTabControl.Extensions;
using DryIoc;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragableTabControl.ViewModels
{
    public abstract class ViewModelBase : BindableBase, INavigationAware
    {
        private string viewName;

        public string ViewName
        {
            get { return viewName; }
            set { viewName = value; RaisePropertyChanged(); }
        }

        private bool isClosable = true;

        public bool IsClosable
        {
            get { return isClosable; }
            set { isClosable = value; RaisePropertyChanged(); }
        }

        private string navigationUri;

        public string NavigationUri
        {
            get { return navigationUri; }
            set { navigationUri = value; RaisePropertyChanged(); }
        }

        public DelegateCommand RefreshCommand { get; set; }
        public DelegateCommand AddCommand { get; set; }
        public DelegateCommand CloseTabCommand { get; set; }

        private readonly IRegionManager regionManager;
        private readonly IContainerProvider containerProvider;

        public ViewModelBase(IContainerProvider containerProvider)
        {
            this.containerProvider = containerProvider;
            regionManager = containerProvider.Resolve<IRegionManager>();
            RefreshCommand = new DelegateCommand(Refresh);
            AddCommand = new DelegateCommand(AddItem);
            CloseTabCommand = new DelegateCommand(CloseTab);
        }
        private void CloseTab()
        {
            // 关闭操作
            // 根据URI获取对应的已注册对象名称
            var obj = containerProvider.Resolve<IContainer>().GetServiceRegistrations();
            // 根据对象名称再从Region的Views里面找到对象
            if (!string.IsNullOrEmpty(navigationUri))
            {
                var region = regionManager.Regions[PrismManager.MainViewRegionName];
                var view = region.Views.FirstOrDefault(v => v.GetType().Name == navigationUri);
                // 把这个对象从Region的Views里移除
                if (view != null)
                    region.Remove(view);
            }
        }


        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
            NavigationUri = navigationContext.Uri.ToString();
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public virtual void Refresh() { }

        public virtual void AddItem() { }
    }
}
