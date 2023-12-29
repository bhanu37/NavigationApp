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
        private readonly LoginViewModel _viewModel;
        private readonly NavigationService<AccountViewModel> navigationService;

        public LoginCommand(LoginViewModel viewModel, NavigationService<AccountViewModel> navigationService)
        {
            _viewModel = viewModel;
            this.navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            MessageBox.Show("Login succes");

            navigationService.Navigate();
        }
    }
}
