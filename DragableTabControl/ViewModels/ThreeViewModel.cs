﻿using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragableTabControl.ViewModels
{
    internal class ThreeViewModel : ViewModelBase
    {
        public ThreeViewModel(IContainerProvider containerProvider) : base(containerProvider)
        {
            ViewName = "ThreeView";
        }
    }
}
