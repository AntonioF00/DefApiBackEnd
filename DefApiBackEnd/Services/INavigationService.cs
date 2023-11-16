using DefApiBackEnd.Core;

namespace DefApiBackEnd.Services
{
    public interface INavigationService
    {
        ViewModel CurrentView { get; set; }

        void NavigateTo<T>() where T : ViewModel;
    }
}
