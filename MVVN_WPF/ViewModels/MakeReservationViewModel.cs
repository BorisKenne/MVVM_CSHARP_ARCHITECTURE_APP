using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        private string _roomNumber;
        public string RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; OnPropertyChanged(RoomNumber); Console.WriteLine("Changing property RoomNumber"); }
        }

        private string _floorNumber;
        public string FloorNumber
        {
            get { return _floorNumber; }
            set { _floorNumber = value; OnPropertyChanged(FloorNumber); Console.WriteLine("Changing property FloorNumber"); }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; OnPropertyChanged(nameof(StartDate)); Console.WriteLine("Changing property StartDate"); }
        }
        private DateTime _endDate;
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; OnPropertyChanged(nameof(EndDate)); Console.WriteLine("Changing property EndDate"); }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel()
        {

        }
    }
}
