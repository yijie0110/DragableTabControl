using Dragablz;
using Prism.Ioc;
using Prism.Regions;
using System.Collections.Specialized;
using System.Windows;

namespace DragableTabControl.Extensions
{
    public class TabRegionAdapter : RegionAdapterBase<TabablzControl>
    {
        public TabRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
        {
        }
        protected override void Adapt(IRegion region, TabablzControl regionTarget)
        {
        }

        protected override void AttachBehaviors(IRegion region, TabablzControl regionTarget)
        {
            base.AttachBehaviors(region, regionTarget);

            if (!region.Behaviors.ContainsKey(DragablzWindowBehavior.BehaviorKey))
                region.Behaviors.Add(DragablzWindowBehavior.BehaviorKey, new DragablzWindowBehavior { activeWindow = regionTarget });
        }
        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }
}
