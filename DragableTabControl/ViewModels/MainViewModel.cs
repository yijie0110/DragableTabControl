using DragableTabControl.Extensions;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;

namespace DragableTabControl.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public DelegateCommand<string> OpenCommand { get; set; }
        private readonly IRegionManager regionManager;
        private InterTabClient interTabClient;

        public InterTabClient InterTabClient
        {
            get { return interTabClient; }
            set { interTabClient = value; RaisePropertyChanged(); }
        }


        public MainViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            OpenCommand = new DelegateCommand<string>(Navigate);
            this.InterTabClient = containerProvider.Resolve<InterTabClient>();
            this.regionManager = regionManager;
        }


        private void Navigate(string viewName)
        {
            if (string.IsNullOrEmpty(viewName))
                return;
            regionManager.Regions[PrismManager.MainViewRegionName].RequestNavigate(viewName);
        }
    }
}
