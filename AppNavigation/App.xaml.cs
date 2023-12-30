using AppNavigation.Services;
using AppNavigation.Stores;
using AppNavigation.ViewModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace AppNavigation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly AccountStore _accountStore;
        private readonly NavigationStore _navigationStore;
        private readonly NavigationBarViewModel _navigationBarViewModel;

        public App()
        {
            _accountStore = new AccountStore();
            _navigationStore = new NavigationStore();
        }

        private NavigationBarViewModel? CreateNavigationBarViewModel()
        {
            return new NavigationBarViewModel(
                _accountStore,
                CreateHomeNavigationService(),
                CreateAccountNavigationService(),
                CreateLoginNavigationService()
                );
        }

        private INavigationService<HomeViewModel> CreateHomeNavigationService()
        {
            return new LayoutNavigationService<HomeViewModel>(_navigationStore, CreateNavigationBarViewModel, () => new HomeViewModel(CreateLoginNavigationService()));
        }

        private INavigationService<AccountViewModel> CreateAccountNavigationService()
        {
            return new LayoutNavigationService<AccountViewModel>(_navigationStore, CreateNavigationBarViewModel, () => new AccountViewModel(_accountStore, CreateHomeNavigationService()));
        }

        private INavigationService<LoginViewModel> CreateLoginNavigationService()
        {
            return new NavigationService<LoginViewModel>(_navigationStore, () => new LoginViewModel(_accountStore, CreateAccountNavigationService()));
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var homeNavigationService = CreateHomeNavigationService();
            homeNavigationService.Navigate();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
