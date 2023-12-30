using AppNavigation.Model;
using AppNavigation.Services;
using AppNavigation.Stores;
using AppNavigation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppNavigation.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly AccountStore _accountStore;
        private readonly LoginViewModel _viewModel;
        private readonly INavigationService<AccountViewModel> navigationService;

        public LoginCommand(LoginViewModel viewModel, AccountStore accountStore, INavigationService<AccountViewModel> navigationService)
        {
            _accountStore = accountStore;
            _viewModel = viewModel;
            this.navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            MessageBox.Show("Login succes");

            _accountStore.CurrentAccount = new Account()
            {
                Username = _viewModel.Username,
                Email = $"{_viewModel.Username}@gmail.com"
            };
            navigationService.Navigate();
        }
    }
}
