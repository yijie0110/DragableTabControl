using DragableTabControl.Extensions;
using Prism.Ioc;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragableTabControl.ViewModels
{
    internal class HostViewModel : BindableBase
    {
        private InterTabClient interTabClient;
        private readonly IContainerProvider containerProvider;

        public InterTabClient InterTabClient
        {
            get { return interTabClient; }
            set { interTabClient = value; RaisePropertyChanged(); }
        }

        public HostViewModel(IContainerProvider containerProvider)
        {
            this.InterTabClient = containerProvider.Resolve<InterTabClient>();
            this.containerProvider = containerProvider;
        }

    }
}
