using AppNavigation.Commands;
using AppNavigation.Services;
using AppNavigation.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppNavigation.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        public ICommand NavigateToAccount { get; set; }
        public ICommand NavigateToLogin { get; set; }

        public HomeViewModel(INavigationService<LoginViewModel> loginNavigationService)
        {
            NavigateToLogin = new NavigationCommand<LoginViewModel>(loginNavigationService);
        }
    }
}
