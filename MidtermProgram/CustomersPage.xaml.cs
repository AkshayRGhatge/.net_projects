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
    /// Interaction logic for CustomersPage.xaml
    /// </summary>
    public partial class CustomersPage : Window
    {
        private List<Customer> cust = new List<Customer>();
        public CustomersPage()
        {
            InitializeComponent();
            cust.Add(new Customer(0, "Akshay", "Brampton", "akshayghatge6011@gmail.com","4372374321"));
            cust.Add(new Customer(1, "Raman", "Toronto","raman@gmail.com","4698571230"));
            cust.Add(new Customer(2, "Pradip", "Mahesvari","pradip@gmail.com","9874561230"));
            cust.Add(new Customer(3, "Rutvij", "Purani","rutvijpurani96@gmail.com","7865412399"));
            cust.Add(new Customer(4, "Bhavesh", "Chauhan","bhavesh@gmail.com","7567945780"));

            var custnames = from cu in cust
                       select cu.Name;

            lstCustomer.DataContext = custnames;

        }

        private void lstCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstCustomer.SelectedIndex;
            var selectedCustomer = from cu in cust
                               where cu.ID == i
                               select cu;

            foreach (var c in selectedCustomer)
            {
                tbName.Text = c.Name;
                tbAddress.Text = c.Address;
                tbEmail.Text = c.Email;
                tbPhone.Text = c.Phone;
            }
        }


        public void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            if (tbName.Text == "" || tbName.Text == "" ||
               tbAddress.Text == "" || tbPhone.Text == "")
            {
                MessageBox.Show("Please Enter the value in the textbox", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                cust.Add(new Customer(cust.Count, tbName.Text,tbAddress.Text, tbEmail.Text,
                            tbPhone.Text));

                var custNames = from cu in cust
                            select cu.Name;

                lstCustomer.DataContext = custNames;
            }

        }
        public void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update?", "update", MessageBoxButton.YesNo,
                 MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                Customer ct = new Customer(lstCustomer.SelectedIndex, tbName.Text, tbAddress.Text, tbEmail.Text, tbPhone.Text);
                cust[lstCustomer.SelectedIndex] = ct;

                var custNames = from cu in cust
                                select cu.Name;

                lstCustomer.DataContext = custNames;
            }
        }
        public void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "delete", MessageBoxButton.YesNo,
                 MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                cust.RemoveAt(lstCustomer.SelectedIndex);

                for (int i = 0; i < cust.Count; i++)
                    cust[i].ID = i;

                var custNames = from cu in cust
                                select cu.Name;

                lstCustomer.DataContext = custNames;
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

