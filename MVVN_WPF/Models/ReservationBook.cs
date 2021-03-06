using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVN_WPF.Exceptions;

namespace MVVN_WPF.Models 
{ 
    public class ReservationBook
    {
        private readonly  List<Reservation> _reservations;
        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }
        public List<Reservation> GetAllReservations() {   return _reservations;  }
        public IEnumerable<Reservation> GEtReservationForUser(string username)
        {
            return _reservations.Where(r=> r.Usermame == username);
        }
        public void AddReservation(Reservation reservation) 
        {
            foreach (var existingReservation in _reservations)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }

            }
            _reservations.Add(reservation);
        }

    }
}
