using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVN_WPF.Models;
using MVVN_WPF.Commands;
using MVVN_WPF.Stores;
using MVVN_WPF.Services;

namespace MVVN_WPF.ViewModels
{
    public class ReservationListingViewModel:ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservation;
        private readonly NavigationService _reservationLIstingViewNavigationService;
        private readonly Hotel _hotel;

        public IEnumerable<ReservationViewModel> reservationEnumerable => _reservation;
        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel(Hotel hotel,NavigationService reservationLIstingViewNavigationService)
        {
            _reservation = new ObservableCollection<ReservationViewModel>();
            _hotel= hotel;
            _reservationLIstingViewNavigationService = reservationLIstingViewNavigationService;

           

            MakeReservationCommand = new NavigateCommand(_reservationLIstingViewNavigationService);
            UpdateReservation();

        }
        private void UpdateReservation()
        {
            _reservation.Clear();
            foreach (var reservation in _hotel.GetAllReservations())
            {
                ReservationViewModel reservationViewModel = new ReservationViewModel(reservation);
                _reservation.Add(reservationViewModel);
            }

        }
    }
}
