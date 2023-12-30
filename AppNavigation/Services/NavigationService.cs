using AppNavigation.Stores;
using AppNavigation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNavigation.Services
{
    public class NavigationService<TViewModel> : INavigationService<TViewModel> where TViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _currentViewModel;

        public NavigationService(NavigationStore navigationStore, Func<TViewModel> currentViewModel)
        {
            _navigationStore = navigationStore;
            _currentViewModel = currentViewModel;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _currentViewModel();
        }
    }
}
