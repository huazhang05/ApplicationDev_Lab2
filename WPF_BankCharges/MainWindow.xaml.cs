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

namespace WPF_BankCharges
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
            double accountBalance = Convert.ToDouble(accountBalanceInput.Text);
            int numberOfCheck = Convert.ToInt32(checksNumbersInput.Text);

            double monthlyserviceFee;

            if (accountBalance < 400)
            {
                if (numberOfCheck < 20)
                    monthlyserviceFee = 25 + 0.1 * numberOfCheck;
                else if (numberOfCheck >= 20 && numberOfCheck < 39)
                    monthlyserviceFee = 25 + 0.08 * numberOfCheck;
                else if (numberOfCheck >= 40 && numberOfCheck < 59)
                    monthlyserviceFee = 25 + 0.06 * numberOfCheck;
                else
                    monthlyserviceFee = 25 + 0.04 * numberOfCheck;
            }
            else
            {
                if (numberOfCheck < 20)
                    monthlyserviceFee = 10 + 0.1 * numberOfCheck;
                else if (numberOfCheck >= 20 && numberOfCheck < 39)
                    monthlyserviceFee = 10 + 0.08 * numberOfCheck;
                else if (numberOfCheck >= 40 && numberOfCheck < 59)
                    monthlyserviceFee = 10 + 0.06 * numberOfCheck;
                else
                    monthlyserviceFee = 10 + 0.04 * numberOfCheck;
            }

            serviceFee.Text = Convert.ToString(monthlyserviceFee);
        }
    }
}
