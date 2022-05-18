using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MVVN_WPF.Exceptions;
using MVVN_WPF.Models;
using MVVN_WPF.Services;
using MVVN_WPF.ViewModels;

namespace MVVN_WPF.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;
        private readonly NavigationService _reservationViewNavgationService;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel,NavigationService reservationViewNavgationService)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
            _reservationViewNavgationService = reservationViewNavgationService;
        }
        public override bool CanExecute(object parameter)
        {
            return base.CanExecute(parameter); // implement the activation of button !!
        }
        public override void Execute(object parameter)
        {
            Reservation reservation = new Reservation(new RoomID(_makeReservationViewModel.RoomNumber, 
                                                                 _makeReservationViewModel.FloorNumber
                                                                 ), 
                                                      _makeReservationViewModel.Username, 
                                                      _makeReservationViewModel.StartDate, 
                                                      _makeReservationViewModel.EndDate
                                                      );
            try
            {
                _hotel.MakeReservation(reservation);
                MessageBox.Show("Successfully reserved room","Success",MessageBoxButton.OK,MessageBoxImage.Information);
                _reservationViewNavgationService.Navigate();
            }catch (ReservationConflictException)
            {
                MessageBox.Show("SThis room is alredy taken", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
