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
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (testScoreApp.IsChecked == true)
            {
                TestScoreWindow tsWindow = new TestScoreWindow();
                tsWindow.Show();
                this.Close();
            }
            else if (bankChargeApp.IsChecked == true) 
            {
                BankChargeWindow bcWindow = new BankChargeWindow();
                bcWindow.Show();
                this.Close();
            }
                
        }

        private void testScoreApp_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
