using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVN_WPF.Models;

namespace MVVN_WPF.ViewModels
{
    public class ReservationViewModel:ViewModelBase
    {
        readonly Reservation _reservation;
        public string RoomID => _reservation.RoomID.RoomNumber.ToString();
        public string Usermame => _reservation.Usermame.ToString();
        public string StartTime => _reservation.StartTime.ToString("d");
        public string EndTime => _reservation.EndTime.ToString("d");

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
