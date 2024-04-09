using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    public partial class Page5 : Page
    {
        DispatcherTimer _timer;
        TimeSpan _time;
        int counter = CounterTransfer.counter;
        public Page5()
        {
            InitializeComponent();
            pageFiveTxt.Text = "Finally, the first day of work is over. At home, you decided to surf YouTube a little more. Having chosen your favorite video, you went away from your computer to pour coffee and on your return you notice that your computer starts issuing strange requests to remote servers, what will you do?\r\n";
            _time = TimeSpan.FromSeconds(90);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("mm':'ss");
                if (_time == TimeSpan.Zero)
                {
                    _timer.Stop();
                    CounterTransfer.counter += 1;
                    NavigationService.Navigate(new Page6());
                }
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }
        private void nextFromOne(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\asala\OneDrive\Рабочий стол\EnProj\text_quest\bin\Debug\net8.0-windows\bad.wav");
            player.Play();
            CounterTransfer.counter += 1;
            _timer.Stop();
            NavigationService.Navigate(new Page6());
        }
        private void nextFromTwo(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\asala\OneDrive\Рабочий стол\EnProj\text_quest\bin\Debug\net8.0-windows\mid.wav");
            player.Play();
            CounterTransfer.counter += 2;
            _timer.Stop();
            NavigationService.Navigate(new Page6());
        }
        private void nextFromThree(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\asala\OneDrive\Рабочий стол\EnProj\text_quest\bin\Debug\net8.0-windows\good.wav");
            player.Play();
            CounterTransfer.counter += 3;
            _timer.Stop();
            NavigationService.Navigate(new Page6());
        }
    }
}
