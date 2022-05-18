using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVN_WPF.ViewModels;

namespace MVVN_WPF.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel { 
            get { return _currentViewModel; } 
            set { _currentViewModel = value; }
        }
    }
}
