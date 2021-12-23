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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MidtermProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int superUser;

        public MainWindow()
        {
            InitializeComponent();
            Logins log = new Logins();
            superUser = log.SuperUser;
        }

        private void menusQuit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Quit?", "Quit", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }

        private void btn_Customers_Click(object sender, RoutedEventArgs e)
        {
            CustomersPage cus = new CustomersPage();
            cus.Title = "Customer";
            cus.ShowDialog();
        }

        private void btn_Airlines_Click(object sender, RoutedEventArgs e)
        {
            AirlinesPage air = new AirlinesPage();
            air.Title = "Airline";
            air.ShowDialog();
        }

        private void btn_Flights_Click(object sender, RoutedEventArgs e)
        {
           
            FlightsPage fli = new FlightsPage();
            fli.Title = "Flight";
            fli.ShowDialog();
        }

        private void btn_Passengers_Click(object sender, RoutedEventArgs e)
        {
            Passengers pas = new Passengers();
            pas.Title = "Passengers";
            pas.ShowDialog();
        }

        private void menuHelp_Click(object sender, RoutedEventArgs e)
        {
            helpWindow help = new helpWindow();
            help.Title = "About us";
            help.ShowDialog();
        }
    }
}
