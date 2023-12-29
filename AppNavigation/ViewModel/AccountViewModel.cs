using AppNavigation.Commands;
using AppNavigation.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppNavigation.ViewModel
{
    public class AccountViewModel : ViewModelBase
    {
        public ICommand NavigateToHome { get; set; }

        public AccountViewModel(NavigationStore navigationStore)
        {
            NavigateToHome = new NavigationCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
        }
    }
}
