using Dragablz;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragableTabControl.Extensions
{
    public class DragablzWindowEvent : PubSubEvent<DragablzWindowEventArgs>
    {

    }
    public class DragablzWindowEventArgs
    {
        public DragablzWindowEventType Type { get; set; }
        public TabablzControl TabControl { get; set; }
    }

    public enum DragablzWindowEventType
    {
        Opened,
        Closed,
        Activated
    }
}
