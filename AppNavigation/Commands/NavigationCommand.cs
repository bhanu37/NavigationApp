using AppNavigation.Services;
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
        private readonly INavigationService<TViewModel> navigationService;

        public NavigationCommand(INavigationService<TViewModel> navigationService)
        {
            this.navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            navigationService.Navigate();
        }
    }
}
