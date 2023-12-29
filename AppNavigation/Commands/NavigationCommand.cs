using AppNavigation.Stores;
using AppNavigation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNavigation.Commands
{
    public class NavigationCommand<TViewModel> : CommandBase 
        where TViewModel : ViewModelBase
    {
        private NavigationStore _navigationStore;
        private Func<TViewModel> _currentViewModel;

        public NavigationCommand(NavigationStore navigationStore, Func<TViewModel> currentViewModel)
        {
            _navigationStore = navigationStore;
            _currentViewModel = currentViewModel;
        }
        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = _currentViewModel();
        }
    }
}
