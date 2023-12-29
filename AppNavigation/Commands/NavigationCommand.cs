﻿using AppNavigation.Services;
using AppNavigation.Stores;
using AppNavigation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNavigation.Commands
{
    public class NavigationCommand<TViewModel> : CommandBase 
        where TViewModel : ViewModelBase
    {
        private readonly NavigationService<TViewModel> navigationService;

        public NavigationCommand(NavigationService<TViewModel> navigationService)
        {
            this.navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            navigationService.Navigate();
        }
    }
}
