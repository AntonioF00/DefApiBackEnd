using DefApiBackEnd.Core;

namespace DefApiBackEnd.Services
{
    public class NavigationService : ObservableObject, INavigationService
    {
        private ViewModel _currentView;
        private Func<Type, ViewModel> _viewModelFactory;
        public ViewModel CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public NavigationService(Func<Type, ViewModel> viewModelFactory, IServiceProvider services)
        {
            _viewModelFactory = viewModelFactory;

            //_currentView = services.GetService(typeof(ResourceModel)) as ResourceModel;
        }
        public void NavigateTo<TViewModel>() where TViewModel : ViewModel
        {
            ViewModel viewModel = _viewModelFactory.Invoke(typeof(TViewModel));
            CurrentView = viewModel;
        }
    }
}
