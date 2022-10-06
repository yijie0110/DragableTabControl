using DragableTabControl.Extensions;
using Prism.Events;
using System;
using System.Windows;

namespace DragableTabControl.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        private readonly IEventAggregator eventAggregator;
        public MainView()
        {
            InitializeComponent();
        }
        public MainView(IEventAggregator eventAggregator) : this()
        {
            this.eventAggregator = eventAggregator;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            eventAggregator.GetEvent<DragablzWindowEvent>().Publish(new DragablzWindowEventArgs() { TabControl = Tabs, Type = DragablzWindowEventType.Opened });
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            eventAggregator.GetEvent<DragablzWindowEvent>().Publish(new DragablzWindowEventArgs() { TabControl = Tabs, Type = DragablzWindowEventType.Activated });
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            eventAggregator.GetEvent<DragablzWindowEvent>().Publish(new DragablzWindowEventArgs() { TabControl = Tabs, Type = DragablzWindowEventType.Closed });
        }
    }
}
