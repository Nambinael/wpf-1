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

namespace Практическая__1
{
    public partial class MainWindow : Window
    { 
        List<int> ResultsForCheck = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public MainWindow()
        {
            InitializeComponent();
        }

        public void RNG()
        {
           
            Random i = new Random();
            int robot = i.Next(1,9);
            if (robot == 0 && ResultsForCheck[0] != 1)
            {
                btn1.Content = "0";
                ResultsForCheck[0] = -1;
                btn1.IsEnabled = false;
            }
            else if (robot == 1 && ResultsForCheck[1] != 1)
            {
                btn2.Content = "0";
                ResultsForCheck[1] = -1;
                btn2.IsEnabled = false;
            }
            else if (robot == 2 && ResultsForCheck[2] != 1)
            {
                btn3.Content = "0";
                ResultsForCheck[2] = -1;
                btn3.IsEnabled = false;
            }
            else if (robot == 3 && ResultsForCheck[3] != 1)
            {
                btn4.Content = "0";
                ResultsForCheck[3] = -1;
                btn4.IsEnabled = false;
            }
            else if (robot == 4 && ResultsForCheck[4] != 1)
            {
                btn5.Content = "0";
                ResultsForCheck[4] = -1;
                btn5.IsEnabled = false;
            }
            else if (robot == 5 && ResultsForCheck[5] != 1)
            {
                btn6.Content = "0";
                ResultsForCheck[5] = -1;
                btn6.IsEnabled = false;
            }
            else if (robot == 6 && ResultsForCheck[6] != 1)
            {
                btn7.Content = "0";
                ResultsForCheck[6] = -1;
                btn7.IsEnabled = false;
            }
            else if (robot == 7 && ResultsForCheck[7] != 1)
            {
                btn8.Content = "0";
                ResultsForCheck[7] = -1;
                btn8.IsEnabled = false;
            }
            else
            {
                btn9.Content = "0";
                ResultsForCheck[8] = -1;
                btn9.IsEnabled = false;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            btn1.Content = "X";
            ResultsForCheck[0] = 1;
            btn1.IsEnabled = false;
            RNG();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btn2.Content = "X";
            ResultsForCheck[1] = 1;
            btn2.IsEnabled = false;
            RNG();

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            btn3.Content = "X";
            ResultsForCheck[2] = 1;
            btn3.IsEnabled = false;
            RNG();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            btn4.Content = "X";
            ResultsForCheck[3] = 1;
            btn4.IsEnabled = false;
            RNG();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            btn5.Content = "X";
            ResultsForCheck[4] = 1;
            btn5.IsEnabled = false;
            RNG();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            btn6.Content = "X";
            ResultsForCheck[5] = 1;
            btn6.IsEnabled = false;
            RNG();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            btn7.Content = "X";
            ResultsForCheck[6] = 1;
            btn7.IsEnabled = false;
            RNG();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            btn8.Content = "X";
            ResultsForCheck[7] = 1;
            btn8.IsEnabled = false;
            RNG();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            btn9.Content = "X";
            ResultsForCheck[8] = 1;
            btn5.IsEnabled = false;
            RNG();
        }

        private void ___Без_имени__Click(object sender, RoutedEventArgs e)
        {
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
        }
    }
}
