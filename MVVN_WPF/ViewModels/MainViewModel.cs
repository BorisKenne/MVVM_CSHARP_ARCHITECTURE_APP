using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVN_WPF.Models;

namespace MVVN_WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get;}

        public MainViewModel(Hotel hotel)
        {
            CurrentViewModel = new MakeReservationViewModel(hotel);
        }
    }
}
