using AppNavigation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNavigation.Stores
{
    public class AccountStore
    {
		private Account _currentAccount;
		
		public bool isLoggedIn => CurrentAccount != null;
		public Account CurrentAccount
		{
			get { return _currentAccount; }
			set { _currentAccount = value; }
		}

	}
}
