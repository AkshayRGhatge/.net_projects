using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace MidtermProgram
{
    /// <summary>
    /// Interaction logic for Passengers.xaml
    /// </summary>
    public partial class Passengers : Window
    {
        private Stack<Passenger> passengers = new Stack<Passenger>();
        public Passengers()
        {
            InitializeComponent();
         
            passengers.Push(new Passenger(0, 4, 4));
            passengers.Push(new Passenger(1, 3, 3));
            passengers.Push(new Passenger(2, 2, 2));
            passengers.Push(new Passenger(3, 1, 1));
            passengers.Push(new Passenger(4, 0, 0));

            var passenger = from pass in passengers
                       select pass.ID;
            lstPassenger.DataContext = passenger;
        }
        private void lstPassengers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstPassenger.SelectedIndex;
            var passenger = from p in passengers
                            where p.ID == i
                            select p;

            foreach (var p in passenger)
            {
                txtID.Text = p.ID.ToString();
                txtCustID.Text = p.CustomerID.ToString();
                txtFlightId.Text = p.FlightID.ToString();
            }
        }
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            if (txtID.Text == "" || txtCustID.Text == "" ||
                txtFlightId.Text == "")
            {
                MessageBox.Show("No text box can be empty", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
             passengers.Push(new Passenger(Int16.Parse(txtID.Text), Int16.Parse(txtCustID.Text), Int16.Parse(txtFlightId.Text)));

                var passenger = from p in passengers
                           select p.ID;

                lstPassenger.DataContext = passenger;
            }
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update?","update", MessageBoxButton.YesNo,
                 MessageBoxImage.Information) == MessageBoxResult.Yes)
            { 
            }
            }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "delete", MessageBoxButton.YesNo,
                 MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                passengers.Pop();

                var passenger = from p in passengers
                                select p.ID;

                lstPassenger.DataContext = passenger;
            }
        }
        private void menuQuit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Quit?", "Quit", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }
        private void menuHelp_Click(object sender, RoutedEventArgs e)
        {
            helpWindow help = new helpWindow();
            help.Title = "About us";
            help.ShowDialog();
        }

    }
}
