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

namespace WPF_TestScore
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
            double score1 = Convert.ToDouble(input1.Text);
            double score2 = Convert.ToDouble(input2.Text);
            double score3 = Convert.ToDouble(input3.Text);

            double courseAvg = (score1 + score2 + score3) / 3;

            averageScore.Text =Convert.ToString (courseAvg);

            if (courseAvg >= 90 && courseAvg <= 100)
            {
                letterGrade.Text= "A";
            }
            else if (courseAvg >= 80 && courseAvg < 90)
            {
                letterGrade.Text = "B";
            }
            else if (courseAvg >= 70 && courseAvg < 80)
            {
                letterGrade.Text = "C";
            }
            else if (courseAvg >= 60 && courseAvg < 70)
            {
                letterGrade.Text = "D";
            }
            else
            { letterGrade.Text = "Fail"; 
            }

        }
    }
}
