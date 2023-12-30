using AppNavigation.Commands;
using AppNavigation.Model;
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
    public class AccountViewModel : ViewModelBase
    {
        private AccountStore _accountStore;

        public NavigationBarViewModel NavigationBarViewModel { get; set; }
        public string Username => _accountStore.CurrentAccount?.Username;
        public string Email => _accountStore.CurrentAccount?.Email;

        public ICommand NavigateToHome { get; set; }

        public AccountViewModel(AccountStore accountStore, NavigationBarViewModel? navigationBarViewModel, NavigationService<HomeViewModel> homeNavigationService)
        {
            NavigationBarViewModel = navigationBarViewModel;
            _accountStore = accountStore;
            NavigateToHome = new NavigationCommand<HomeViewModel>(homeNavigationService);
        }
    }
}
