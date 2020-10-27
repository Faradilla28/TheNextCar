using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TheNextCar.Controller;

namespace TheNextCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , OnPowerChanged , OnDoorChanged , OnCarEngineStateChanged
    {
        private Car nextCar;
        public MainWindow()
        {
            InitializeComponent();

            AccubatteryController accubatteryController = new AccubatteryController(this);
            DoorController doorController = new DoorController(this);

            nextCar = new Car(doorController, accubatteryController, this);
        }

        private void OnStartButton(object sender, RoutedEventArgs e)
        {
            this.nextCar.startEngine();   
        }

        private void OnDoorOpenButtonClicked(object sender, RoutedEventArgs e)
        {
            this.nextCar.toggleTheOpenDoorButton();
        }

        private void OnLockDoorButtonClicked(object sender, RoutedEventArgs e)
        { 
            this.nextCar.toggleTheLockDoorButton();
        }

        private void OnAccuButtonClicked(object sender, RoutedEventArgs e)
        {
            this.nextCar.togglePowerButton();
        }

        public void onPowerChangedStatus(string value, string message)
        {
            AccuState.Content = message;
            AccuButton.Content = value;
        }

        public void onLockDoorStateChanged(string value, string massage)
        {
            LockDoorState.Content = massage;
            LockDoorButton.Content = value;
        }

        public void onDoorOpenStateChanged(string value, string massage)
        {
            DoorOpenState.Content = massage;
            DoorOpenButton.Content = value;
        }

        public void onCarEngineStateChanged(string value, string messange)
        {
            status.Content = messange;
            startButton.Content = value;
        }
    }
}
 