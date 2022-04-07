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

namespace monitor_tester
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
            one.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            two.Background = new SolidColorBrush(Color.FromRgb(0, 204, 255));
            three.Background = new SolidColorBrush(Color.FromRgb(0, 212, 0));
            four.Background = new SolidColorBrush(Color.FromRgb(212, 0, 170));
            five.Background = new SolidColorBrush(Color.FromRgb(212, 0, 0));
            six.Background = new SolidColorBrush(Color.FromRgb(0, 0, 254));
            seven.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            one.Background = new SolidColorBrush(Color.FromRgb(0, 204, 255));
            two.Background = new SolidColorBrush(Color.FromRgb(50, 204, 245));
            three.Background = new SolidColorBrush(Color.FromRgb(75, 204, 235));
            four.Background = new SolidColorBrush(Color.FromRgb(100, 204, 225));
            five.Background = new SolidColorBrush(Color.FromRgb(125, 204, 215));
            six.Background = new SolidColorBrush(Color.FromRgb(150, 204, 205));
            seven.Background = new SolidColorBrush(Color.FromRgb(175, 204, 205));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            one.Background = new SolidColorBrush(Color.FromRgb(0, 212, 0));
            two.Background = new SolidColorBrush(Color.FromRgb(50, 212, 0));
            three.Background = new SolidColorBrush(Color.FromRgb(75, 212, 0));
            four.Background = new SolidColorBrush(Color.FromRgb(100, 212, 0));
            five.Background = new SolidColorBrush(Color.FromRgb(125, 212, 0));
            six.Background = new SolidColorBrush(Color.FromRgb(150, 212, 0));
            seven.Background = new SolidColorBrush(Color.FromRgb(175, 212, 0));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            one.Background = new SolidColorBrush(Color.FromRgb(212, 0, 170));
            two.Background = new SolidColorBrush(Color.FromRgb(212, 50, 170));
            three.Background = new SolidColorBrush(Color.FromRgb(212, 75, 170));
            four.Background = new SolidColorBrush(Color.FromRgb(212, 100, 170));
            five.Background = new SolidColorBrush(Color.FromRgb(212, 125, 170));
            six.Background = new SolidColorBrush(Color.FromRgb(212, 150, 170));
            seven.Background = new SolidColorBrush(Color.FromRgb(212, 175, 170));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            one.Background = new SolidColorBrush(Color.FromRgb(212, 0, 0));
            two.Background = new SolidColorBrush(Color.FromRgb(212, 0, 50));
            three.Background = new SolidColorBrush(Color.FromRgb(212, 0, 75));
            four.Background = new SolidColorBrush(Color.FromRgb(212, 0, 100));
            five.Background = new SolidColorBrush(Color.FromRgb(212, 0, 125));
            six.Background = new SolidColorBrush(Color.FromRgb(212, 0, 150));
            seven.Background = new SolidColorBrush(Color.FromRgb(212, 0, 175));

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            one.Background = new SolidColorBrush(Color.FromRgb(0, 0, 254));
            two.Background = new SolidColorBrush(Color.FromRgb(50, 0, 254));
            three.Background = new SolidColorBrush(Color.FromRgb(75, 0, 254));
            four.Background = new SolidColorBrush(Color.FromRgb(100, 0, 254));
            five.Background = new SolidColorBrush(Color.FromRgb(125, 0, 254));
            six.Background = new SolidColorBrush(Color.FromRgb(150, 0, 254));
            seven.Background = new SolidColorBrush(Color.FromRgb(175, 0, 254));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            one.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            two.Background = new SolidColorBrush(Color.FromRgb(12, 12, 12));
            three.Background = new SolidColorBrush(Color.FromRgb(25,25, 25));
            four.Background = new SolidColorBrush(Color.FromRgb(50, 50, 50));
            five.Background = new SolidColorBrush(Color.FromRgb(100, 100, 100));
            six.Background = new SolidColorBrush(Color.FromRgb(150, 150, 150));
            seven.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
        }
    }
}
