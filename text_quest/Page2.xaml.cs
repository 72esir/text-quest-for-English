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
using System.Windows.Threading;

namespace text_quest
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        DispatcherTimer _timer;
        TimeSpan _time;
        public Page2()
        {
            InitializeComponent();

            _time = TimeSpan.FromSeconds(10);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("ss");
                if (_time == TimeSpan.Zero)
                {
                    _timer.Stop();
                    CounterTransfer.counter += 0;
                    NavigationService.Navigate(new Page3());
                }
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }
        public class CounterTransfer
        {
            public static int counter { get; set; }
        }
        private void nextFromOne(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            CounterTransfer.counter += 1;
            NavigationService.Navigate(new Page3());
        }
        private void nextFromTwo(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            CounterTransfer.counter += 2;
            NavigationService.Navigate(new Page3());
        }
        private void nextFromThree(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            CounterTransfer.counter += 3;
            NavigationService.Navigate(new Page3());
        }
    }
}
