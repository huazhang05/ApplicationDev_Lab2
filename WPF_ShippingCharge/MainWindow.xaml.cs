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

namespace WPF_ShippingCharge
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
            double weight = Convert.ToDouble(weightInput.Text);
            double distance = Convert.ToDouble(distanceInput.Text);

            double shippingFee;
            double number = distance / 500; ;
            int times = (int)Math.Ceiling(number); ;
            if (weight <= 2)
                shippingFee = 1.1 * times;
            else if (weight > 2 && weight <= 6)
                shippingFee = 2.2 * times;
            else if (weight > 6 && weight <= 10)
                shippingFee = 3.7 * times;
            else
                shippingFee = 4.7 * times;

            shippingChargeReslt.Text = Convert.ToString(shippingFee);
        }
    }
}
