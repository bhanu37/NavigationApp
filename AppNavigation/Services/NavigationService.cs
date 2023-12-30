using AppNavigation.Stores;
using AppNavigation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNavigation.Services
{
    public class NavigationService<TViewModel>
        where TViewModel : ViewModelBase
    {
        private readonly AccountStore _accountStore;
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _currentViewModel;

        public NavigationService(NavigationStore navigationStore, AccountStore accountStore, Func<TViewModel> currentViewModel)
        {
            _accountStore = accountStore;
            _navigationStore = navigationStore;
            _currentViewModel = currentViewModel;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _currentViewModel();
        }
    }
}
