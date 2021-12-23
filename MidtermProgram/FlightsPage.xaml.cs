using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
    /// Interaction logic for FlightsPage.xaml
    /// </summary>
    public partial class FlightsPage : Window
    {
        private int superUser;
        private List<Flights> fli = new List<Flights>();
        private int airline_id;
        private int sup;

        public FlightsPage()
        {
            Logins log = new Logins();
            superUser = log.SuperUser;

            Airlines air = new Airlines();
            airline_id = air.ID;
            InitializeComponent();

            fli.Add(new Flights(0, 0,"Brampton", "Ottawa", "25-Jun-2020", 18));
            fli.Add(new Flights(1,0, "Delhi", "Toronto", "30-Jun-2020", 6));
            fli.Add(new Flights(2, 2,"Toronta","Calgary", "5-July-2020", 12));
            fli.Add(new Flights(3, 2,"Halifax", "Montreal", "10-July-2020", 10));
            fli.Add(new Flights(4, 1,"NovaScotia", "Toronto", "20-July-2020", 17));

            var fliName = from fl in fli
                            select fl.DepartureCity;

            lstFlight.DataContext = fliName;


          //if (superUser == 0)
           // {

             // btnInsert.Content=                 
                   // MessageBox.Show("You are not Super User", "Error",
                  //  MessageBoxButton.OK, MessageBoxImage.Error);
                //btnInsert.IsEnabled = false;
                //btnInsert.IsEnabled=false;
               // btnUpdate.IsEnabled = false;
                    
              //  btnDelete.IsEnabled = false;
            //} 
        }

        public FlightsPage(int sup)
        {
            this.sup = sup;
        }

        private void lstFlight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int flight = lstFlight.SelectedIndex;
            var selectFlight = from fl in fli
                                   where fl.ID == flight
                                   select fl;

            foreach (var f in selectFlight)
            {
                 txtAirID.Text = f.AirlineID.ToString();
                txtDeptCity.Text = f.DepartureCity;
               txtDestCity.Text = f.DestinationCity;
                txtDeptDate.Text = f.DepartureDate;
                txtFlighTime.Text = f.FlightTime.ToString();
               
            }
        }
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            
                            if (txtAirID.Text == "" || txtDeptCity.Text == "" ||
               txtDestCity.Text == "" || txtDeptDate.Text == "" ||
              txtFlighTime.Text == "")
                {
                    MessageBox.Show("No text box can be empty", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            
            else
            {
                fli.Add(new Flights(fli.Count, Int16.Parse(txtAirID.Text), txtDeptCity.Text, txtDestCity.Text,
                            txtDeptDate.Text, double.Parse(txtFlighTime.Text)));

                var fliName = from f in fli
                              select f.DepartureCity;

                lstFlight.DataContext = fliName;
            }

        }
        public void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update?", "Update", MessageBoxButton.YesNo,
                 MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                Flights ft = new Flights(lstFlight.SelectedIndex, Int16.Parse(txtAirID.Text), txtDeptCity.Text, txtDestCity.Text, txtDeptDate.Text, double.Parse(txtFlighTime.Text));
                fli[lstFlight.SelectedIndex] = ft;

                var fliNames = from f in fli
                               select f.DepartureCity;

                lstFlight.DataContext = fliNames;
            }
        }
        public void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "delete", MessageBoxButton.YesNo,
                 MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                fli.RemoveAt(lstFlight.SelectedIndex);

                for (int i = 0; i < fli.Count; i++)
                    fli[i].ID = i;

                var fliNames = from f in fli
                               select f.DepartureCity;

                lstFlight.DataContext = fliNames;
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
