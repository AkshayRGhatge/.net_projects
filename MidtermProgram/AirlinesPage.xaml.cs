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
    /// Interaction logic for AirlinesPage.xaml
    /// </summary>
    public partial class AirlinesPage : Window
    {
        string airplane,meal;
    
        private Queue<Airlines> a = new Queue<Airlines>();
        public AirlinesPage()
        {
            InitializeComponent();
            a.Enqueue(new Airlines(0, "Quatar", "AirBus 320", 1200, "chicken"));
            a.Enqueue(new Airlines(1, "Singapore Airlines", "Boeing 300", 400, "soup"));
            a.Enqueue(new Airlines(2, "Thai Airway", "Boeing 300", 90, "chicken"));
            a.Enqueue(new Airlines(3, "Air Canada", "Airbus 320", 511, "soup"));
            a.Enqueue(new Airlines(4, "Emirates", "Boeing 300", 110, "chicken"));

            var airLine = from al in a
                          select al.Name;
            lstAirline.DataContext = airLine;

        }
        private void lstAirline_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int al = lstAirline.SelectedIndex;
            var selectedAirlines = from air in a
                                   where air.ID == al
                                   select air;

            foreach (var l in selectedAirlines)
            {
                txtName.Text = l.Name;
                txtAirplane.Text = l.Airplane;
                txtSeat.Text = l.SeatsAvailable.ToString();
                txtMeal.Text = l.MealAvailable;
            }
        }
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "" || txtAirplane.Text == "" ||
                txtSeat.Text == "" || txtMeal.Text == "")
            {
                MessageBox.Show("No text box can be empty", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                a.Enqueue(new Airlines(a.Count, txtName.Text,
                            airplane, Int16.Parse(txtSeat.Text),
                            meal));

                var airNames = from a in a
                            select a.Name;

                lstAirline.DataContext = airNames;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButton.YesNo,
                   MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                Airlines ai = new Airlines(lstAirline.SelectedIndex, txtName.Text,
         airplane, Int32.Parse(txtSeat.Text), meal);
                // a[lstAirline.SelectedIndex] = ai;

                var names = from al in a
                            select al.Name;

                lstAirline.DataContext = names;
            }
              
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "delete", MessageBoxButton.YesNo,
                  MessageBoxImage.Information) == MessageBoxResult.Yes)
            { 
                a.Dequeue();

            var airNames = from a in a
                           select a.Name;

            lstAirline.DataContext = airNames;
        }
        }

        private void menuQuit_Click(object sender, RoutedEventArgs e)
        {
           
                if (MessageBox.Show("Are you sure you want to Quit?", "Quit", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    Application.Current.Shutdown();
            
        }

        private void r1_Checked(object sender, RoutedEventArgs e)
        {
            airplane = "Boeing 777";
        }
        private void r2_Checked(object sender, RoutedEventArgs e)
        {
            airplane = "Airbus 320";
        }

        private void r3_Checked(object sender, RoutedEventArgs e)
        {
            meal = "Soup";
        }

        private void r4_Checked(object sender, RoutedEventArgs e)
        {
            meal = "Chicken";
        }
        private void menuHelp_Click(object sender, RoutedEventArgs e)
        {
            helpWindow help = new helpWindow();
            help.Title = "About us";
            help.ShowDialog();
        }
    }
}

