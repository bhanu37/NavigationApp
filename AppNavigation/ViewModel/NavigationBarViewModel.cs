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
    public class NavigationBarViewModel : ViewModelBase
    {
        private readonly AccountStore _accountStore;

        public ICommand NavigateHomeCommand { get; set; }
        public ICommand NavigateAccountCommand { get; set; }
        public ICommand NavigateLoginCommand { get; set; }
        public bool isLoggedIn => _accountStore.isLoggedIn;

        public NavigationBarViewModel(AccountStore accountStore,
                                        INavigationService<HomeViewModel> homeNavigationService,
                                        INavigationService<AccountViewModel> AccountNavigationService,
                                        INavigationService<LoginViewModel> LoginNavigationService) 
        {
            _accountStore = accountStore;
            NavigateHomeCommand = new NavigationCommand<HomeViewModel>(homeNavigationService);
            NavigateAccountCommand = new NavigationCommand<AccountViewModel>(AccountNavigationService);
            NavigateLoginCommand = new NavigationCommand<LoginViewModel>(LoginNavigationService);
        }

    }
}
