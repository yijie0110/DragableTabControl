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
            containerRegistry.RegisterForNavigation<TestAView, TestAViewModel>();
            containerRegistry.RegisterForNavigation<TestBView, TestBViewModel>();
            containerRegistry.RegisterForNavigation<TestCView, TestCViewModel>();

            containerRegistry.Register<InterTabClient>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);

            var regionBehaviorFactory = Container.Resolve<IRegionBehaviorFactory>();
            regionAdapterMappings.RegisterMapping(typeof(TabablzControl), new TabRegionAdapter(regionBehaviorFactory));

        }
    }
}
