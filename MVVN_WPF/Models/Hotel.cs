using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVN_WPF.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }
        public List<Reservation>GetAllReservations()
        {
            return _reservationBook.GetAllReservations();
        }
        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservationBook.GEtReservationForUser(username);
        }

        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
