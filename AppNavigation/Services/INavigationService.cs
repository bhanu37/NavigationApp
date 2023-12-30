using AppNavigation.ViewModel;

namespace AppNavigation.Services
{
    public interface INavigationService<TViewModel> where TViewModel : ViewModelBase
    {
        void Navigate();
    }
}