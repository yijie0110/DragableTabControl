using DragableTabControl.Extensions;
using DragableTabControl.ViewModels;
using DragableTabControl.Views;
using Dragablz;
using Prism.Ioc;
using Prism.Regions;
using System.Windows;

namespace DragableTabControl
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<OneView, OneViewModel>();
            containerRegistry.RegisterForNavigation<TwoView, TwoViewModel>();
            containerRegistry.RegisterForNavigation<ThreeView, ThreeViewModel>();

            containerRegistry.Register<InterTabClient>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);

            var regionBehaviorFactory = Container.Resolve<IRegionBehaviorFactory>();
            regionAdapterMappings.RegisterMapping(typeof(TabablzControl), new TabRegionAdapter(regionBehaviorFactory, Container));


            //var region = new SingleActiveRegion() { Name = PrismManager.MainViewRegionName };

            //region.Behaviors.Add(DragablzWindowBehavior.BehaviorKey, new DragablzWindowBehavior(Container));

            //Container.Resolve<RegionManager>().Regions.Add(PrismManager.MainViewRegionName, region);
        }
    }
}
