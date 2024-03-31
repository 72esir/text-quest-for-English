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
using static text_quest.Page2;

namespace text_quest
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        int counter = CounterTransfer.counter;
        public Page3()
        {
            InitializeComponent();
        }
        private void nextFromOne(object sender, RoutedEventArgs e)
        {
            CounterTransfer.counter += 1;

            NavigationService.Navigate(new Page4());
        }
        private void nextFromTwo(object sender, RoutedEventArgs e)
        {
            CounterTransfer.counter += 2;

            NavigationService.Navigate(new Page4());
        }
        private void nextFromThree(object sender, RoutedEventArgs e)
        {
            CounterTransfer.counter += 3;

            NavigationService.Navigate(new Page4());
        }
    }
}
