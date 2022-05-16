﻿using System;
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
        public string RoomID => _reservation.RoomID.ToString();
        public string Usermame => _reservation.Usermame.ToString();
        public DateTime StartTime => _reservation.StartTime;
        public DateTime EndTime => _reservation.EndTime;

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}