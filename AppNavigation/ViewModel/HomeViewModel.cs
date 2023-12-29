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

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateToLogin = new NavigationCommand<LoginViewModel>(
                new NavigationService<LoginViewModel>(navigationStore, () => new LoginViewModel(navigationStore)));
        }
    }
}
