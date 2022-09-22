using DragableTabControl.Extensions;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DragableTabControl.Views
{
    /// <summary>
    /// HostView.xaml 的交互逻辑
    /// </summary>
    public partial class HostView : Window
    {
        private readonly IEventAggregator eventAggregator;
        public HostView()
        {
            InitializeComponent();
        }

        public HostView(IEventAggregator eventAggregator) : this()
        {
            this.eventAggregator = eventAggregator;
        }


        private void Window_Activated(object sender, EventArgs e)
        {
            eventAggregator.GetEvent<DragablzWindowEvent>().Publish(new DragablzWindowEventArgs() { TabControl = Tabs, Type = DragablzWindowEventType.Activated });
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            eventAggregator.GetEvent<DragablzWindowEvent>().Publish(new DragablzWindowEventArgs() { TabControl = Tabs, Type = DragablzWindowEventType.Opened });
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            eventAggregator.GetEvent<DragablzWindowEvent>().Publish(new DragablzWindowEventArgs() { TabControl = Tabs, Type = DragablzWindowEventType.Closed });
        }
    }
}
