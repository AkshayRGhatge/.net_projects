using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private Dictionary<string, Logins> login = new Dictionary<string, Logins>();
        private int _superUser;

        public int superUser
        {
            get { return _superUser; }
            set { _superUser = value; }
        }

        public LoginWindow()
        {
            InitializeComponent();
            login["akshay"] = new Logins(1, "ghatge", 1);
            login["raman"] = new Logins(2, "ra", 0);
            login["bhavesh"] = new Logins(3, "chauhan", 0);
            login["pradip"] = new Logins(4, "maheshvari", 0);
            login["rutvij"] = new Logins(5, "purani", 1);


        }

    private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            bool validLogin = (from log in login
                               where log.Key == txtUser.Text && log.Value.Password == txtPass.Password
                               select true).SingleOrDefault();

            superUser = (from log in login
                         where log.Key == txtUser.Text && log.Value.Password == txtPass.Password
                         select log.Value.SuperUser).SingleOrDefault();

            if (validLogin == true)
            {
                if (superUser == 1)
                {
                    MainWindow m = new MainWindow();
                    m.Title = "Welcome SuperUser";
                    m.ShowDialog();
                }
                else
                {
                    MainWindow m = new MainWindow();
                    m.Title = "Welcome";
                    m.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wrong Login", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to ?", "Quit", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
             Application.Current.Shutdown();
           
        }

    }
}
