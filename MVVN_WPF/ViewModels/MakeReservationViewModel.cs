using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVN_WPF.Commands;
using MVVN_WPF.Models;

namespace MVVN_WPF.ViewModels
{
    public class MakeReservationViewModel:ViewModelBase
    {
        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; OnPropertyChanged(Username); Console.WriteLine("Changing property username"); }
        }

        private int _roomNumber;
        public int RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; OnPropertyChanged("RoomNumber"); Console.WriteLine("Changing property RoomNumber"); }
        }

        private int _floorNumber;
        public int FloorNumber
        {
            get { return _floorNumber; }
            set { _floorNumber = value; OnPropertyChanged("FloorNumber"); Console.WriteLine("Changing property FloorNumber"); }
        }

        private DateTime _startDate = new DateTime(2021,1,1);
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; OnPropertyChanged(nameof(StartDate)); Console.WriteLine("Changing property StartDate"); }
        }
        private DateTime _endDate = new DateTime(2021,1,1);
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; OnPropertyChanged(nameof(EndDate)); Console.WriteLine("Changing property EndDate"); }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel(Hotel hotel)
        {
            SubmitCommand = new MakeReservationCommand(this,hotel);
        }
    }
}
