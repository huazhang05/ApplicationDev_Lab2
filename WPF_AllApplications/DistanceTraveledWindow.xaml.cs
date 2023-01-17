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

namespace WPF_AllApplications
{
    /// <summary>
    /// Interaction logic for DistanceTraveledWindow.xaml
    /// </summary>
    public partial class DistanceTraveledWindow : Window
    {
        public DistanceTraveledWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double speed = Convert.ToDouble(speedInput.Text);
            double times = Convert.ToDouble(timesIput.Text);
            double distance;
            distance = speed * times;
            distanceTraveledOutput.Text = Convert.ToString(distance);
        }

        private void backToHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mWindow = new MainWindow();
            mWindow.Show();
            this.Close();
        }
    }
}
