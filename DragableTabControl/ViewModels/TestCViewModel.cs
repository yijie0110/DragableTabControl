using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragableTabControl.ViewModels
{
    internal class TestCViewModel : ViewModelBase
    {
        public TestCViewModel(IContainerProvider containerProvider) : base(containerProvider)
        {
            ViewName = "TestCView";
        }
    }
}
