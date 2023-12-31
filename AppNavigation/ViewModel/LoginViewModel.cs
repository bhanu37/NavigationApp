﻿using AppNavigation.Commands;
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
    public class LoginViewModel : ViewModelBase
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public ICommand LoginCommand { get; set; }

        public LoginViewModel(AccountStore accountStore, INavigationService<AccountViewModel> accountNavigationService)
        {
            LoginCommand = new LoginCommand(this, accountStore, accountNavigationService);
        }

    }
}
