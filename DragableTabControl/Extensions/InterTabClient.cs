using DragableTabControl.Views;
using Dragablz;
using Prism.Ioc;
using System.Windows;

namespace DragableTabControl.Extensions
{
    public class InterTabClient : IInterTabClient
    {
        private readonly IContainerProvider containerProvider;

        public InterTabClient(IContainerProvider containerProvider)
        {
            this.containerProvider = containerProvider;
        }
        public INewTabHost<Window> GetNewHost(IInterTabClient interTabClient, object partition, TabablzControl source)
        {
            var view = containerProvider.Resolve<HostView>();

            return new NewTabHost<Window>(view, view.Tabs);
        }

        public TabEmptiedResponse TabEmptiedHandler(TabablzControl tabControl, Window window)
        {
            if (window is MainView)
            {
                return TabEmptiedResponse.DoNothing;
            }
            else
            {
                return TabEmptiedResponse.CloseWindowOrLayoutBranch;
            }
        }
    }
}
