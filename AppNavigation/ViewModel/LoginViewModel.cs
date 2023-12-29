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
    public class LoginViewModel : ViewModelBase
    {
        public ICommand LoginCommand { get; set; }

        public LoginViewModel(NavigationStore navigationStore)
        {
            LoginCommand = new LoginCommand(this, 
                new NavigationService<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore)));
        }

    }
}
