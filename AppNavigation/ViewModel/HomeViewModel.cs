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
    public class HomeViewModel : ViewModelBase
    {
        public ICommand NavigateToAccount { get; set; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateToAccount = new NavigationCommand<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore));
        }
    }
}
