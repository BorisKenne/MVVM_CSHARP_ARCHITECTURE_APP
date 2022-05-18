using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MVVN_WPF.Exceptions;
using MVVN_WPF.Models;
using MVVN_WPF.Stores;
using MVVN_WPF.ViewModels;

namespace MVVN_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel _hotel;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _hotel = new Hotel("Boris Hotel");
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new ReservationListingViewModel(_navigationStore,createMakeReservationViewModel);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
        private MakeReservationViewModel createMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_hotel,_navigationStore, createReservationListingViewModel);
        }
        private ReservationListingViewModel createReservationListingViewModel()
        {
            return new ReservationListingViewModel(_navigationStore, createMakeReservationViewModel);
        }

    }
}
