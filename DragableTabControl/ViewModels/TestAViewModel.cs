using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragableTabControl.ViewModels
{
    internal class TestAViewModel : ViewModelBase
    {
        public TestAViewModel(IContainerProvider containerProvider) : base(containerProvider)
        {
            ViewName = "TestAView";
        }
    }
}
