using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FinalUWPAkshayGhatge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
   
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void btn_Convert_Click(object sender, RoutedEventArgs e)
        {
            double temp;
            if (txtTemp.Text == "")
            {
                txt_Result.Text = "Textbox is empty Please Enter value";
            }
            else 
            if (celToFah.IsChecked == true)
            {
                temp = (Double.Parse(txtTemp.Text)*9.0/5.0)+32;
                txt_Result.Text = temp.ToString("0.##") + "\u00B0F";
            }
            else
            {
                temp = (Double.Parse(txtTemp.Text) - 32) * 5.0 / 9.0;
                txt_Result.Text = temp.ToString("0.##") + "\u00B0C";
            }
        }

       
    }
}
