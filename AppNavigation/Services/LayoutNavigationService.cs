using AppNavigation.Stores;
using AppNavigation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNavigation.Services
{
    public class LayoutNavigationService<TViewModel> : INavigationService<TViewModel> where TViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<NavigationBarViewModel> _createNavigationBarViewModel;
        private readonly Func<TViewModel> _createViewModel;

        public LayoutNavigationService(NavigationStore navigationStore, Func<NavigationBarViewModel> createNavigationBarViewModel, Func<TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createNavigationBarViewModel = createNavigationBarViewModel;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = new LayoutViewModel(_createNavigationBarViewModel(), _createViewModel());
        }
    }
}
