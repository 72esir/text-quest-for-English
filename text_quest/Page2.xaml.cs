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

namespace text_quest
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }
        public class CounterTransfer
        {
            public static int counter { get; set; }
        }
        private void nextFromOne(object sender, RoutedEventArgs e)
        {
            CounterTransfer.counter += 1;
            NavigationService.Navigate(new Page3());
        }
        private void nextFromTwo(object sender, RoutedEventArgs e)
        {
            CounterTransfer.counter += 2;
            NavigationService.Navigate(new Page3());
        }
        private void nextFromThree(object sender, RoutedEventArgs e)
        {
            CounterTransfer.counter += 3;
            NavigationService.Navigate(new Page3());
        }
    }
}
