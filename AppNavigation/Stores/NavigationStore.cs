using AppNavigation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNavigation.Stores
{
    public class NavigationStore
    {
		private ViewModelBase _viewModelBase;
		public event Action CurrentViewModelChanged;

		public ViewModelBase CurrentViewModel
		{
			get { return _viewModelBase; }
			set 
			{
				_viewModelBase?.Dispose();
				_viewModelBase = value;
				OnCurrentViewModelChanged();
			}
		}

		private void OnCurrentViewModelChanged()
		{
			CurrentViewModelChanged?.Invoke();
		}

    }
}
