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

namespace WPF_AllApplications
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] Operations { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Operations = new string[] { "Test Scores", "Bank Charge", "Shipping Charge", "Distance Travel" };
            DataContext= this;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if ((string)combobox.SelectedValue == "Test Scores")
            {
                TestScoreWindow tsWindow = new TestScoreWindow();
                tsWindow.Show();
                this.Close();
            }
            else if ((string)combobox.SelectedValue == "Bank Charge") 
            {
                BankChargeWindow bcWindow = new BankChargeWindow();
                bcWindow.Show();
                this.Close();
            }
            else if ((string)combobox.SelectedValue == "Shipping Charge")
            {
                ShippingChargeWindow scWindow = new ShippingChargeWindow();
                scWindow.Show();
                this.Close();
            }
            else if ((string)combobox.SelectedValue == "Distance Travel")
            {
                DistanceTraveledWindow dtWindow = new DistanceTraveledWindow();
                dtWindow.Show();
                this.Close();
            }

        }

    }
}
