using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVN_WPF.Models;
using MVVN_WPF.ViewModels;

namespace MVVN_WPF.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
        }
        public override void Execute(object parameter)
        {
            Reservation reservation = new Reservation(new RoomID(_makeReservationViewModel.RoomNumber, _makeReservationViewModel.FloorNumber), 
                                                      _makeReservationViewModel.Username, 
                                                      _makeReservationViewModel.StartDate, 
                                                      _makeReservationViewModel.EndDate
                                                      );
            _hotel.MakeReservation(reservation);
        }
    }
}
