using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragableTabControl.Extensions
{
    public static class PrismManager
    {
        /// <summary>
        /// MainView's main content present Region 
        /// </summary>
        public static readonly string MainViewRegionName = "MainViewRegion";


        public static void CloseAllTabs(this IRegionManager regionManager)
        {
            regionManager.Regions[MainViewRegionName].RemoveAll();
        }
    }
}
