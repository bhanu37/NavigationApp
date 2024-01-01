using AppNavigation.Stores;
using System.Windows.Input;

namespace AppNavigation.Commands
{
    public class LogoutCommand : CommandBase
    {
        public AccountStore AccountStore { get; set; }

        public LogoutCommand(AccountStore accountStore)
        {
            AccountStore = accountStore;
        }

        public override void Execute(object? parameter)
        {
            AccountStore.Logout();
        }
    }
}