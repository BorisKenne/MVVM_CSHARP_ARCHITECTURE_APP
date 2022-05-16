using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVN_WPF.Models;

namespace MVVN_WPF.ViewModels
{
    public class ReservationListingViewModel:ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservation;

        public IEnumerable<ReservationViewModel> reservationEnumerable => _reservation;
        public ICommand MakeReservationCommand { get; }
        public ReservationListingViewModel()
        {
            _reservation = new ObservableCollection<ReservationViewModel>();

            _reservation.Add(new ReservationViewModel(new Reservation(
                                                               new RoomID(1, 2),
                                                               "Singleton",
                                                               DateTime.Now,
                                                               DateTime.Now)));
            Console.WriteLine("Add reservation");
            _reservation.Add(new ReservationViewModel(new Reservation(
                                                               new RoomID(3, 4),
                                                               "Joe",
                                                               DateTime.Now,
                                                               DateTime.Now)));
            Console.WriteLine("Add reservation");
            _reservation.Add(new ReservationViewModel(new Reservation(
                                                               new RoomID(5, 6),
                                                               "Bob",
                                                               DateTime.Now,
                                                               DateTime.Now)));
            Console.WriteLine("Add reservation");
            _reservation.Add(new ReservationViewModel(new Reservation(
                                                               new RoomID(7, 8),
                                                               "Mary",
                                                               DateTime.Now,
                                                               DateTime.Now)));
            Console.WriteLine("Add reservation");

        }
    }
}
