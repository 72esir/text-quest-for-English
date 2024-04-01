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
using static text_quest.Page2;



namespace text_quest
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        DispatcherTimer _timer;
        TimeSpan _time;
        int counter = CounterTransfer.counter;
        public Page7()
        {
            InitializeComponent();

            _time = TimeSpan.FromSeconds(10);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("ss");
                if (_time == TimeSpan.Zero)
                {
                    _timer.Stop();
                    CounterTransfer.counter += 1;
                    NavigationService.Navigate(new Page8());
                }
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }
        private void nextFromOne(object sender, RoutedEventArgs e)
        {
            CounterTransfer.counter += 1;
            _timer.Stop();
            NavigationService.Navigate(new Page8());
        }
        private void nextFromTwo(object sender, RoutedEventArgs e)
        {
            CounterTransfer.counter += 3;
            _timer.Stop();
            NavigationService.Navigate(new Page8());
        }
        private void nextFromThree(object sender, RoutedEventArgs e)
        {
            CounterTransfer.counter += 2;
            _timer.Stop();
            NavigationService.Navigate(new Page8());
        }
    }
}
