﻿using System;
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
    public partial class Page3 : Page
    {
        DispatcherTimer _timer;
        TimeSpan _time;
        int counter = CounterTransfer.counter;
        public Page3()
        {
            InitializeComponent();
            pageThreeTxt.Text = "Having solved the previous problem, you wanted to sit down in your comfortable chair and continue working, but then you notice strange network activity on your computer. What do you do?\r\n";
            _time = TimeSpan.FromSeconds(90);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("mm':'ss");
                if (_time == TimeSpan.Zero)
                {
                    _timer.Stop();
                    CounterTransfer.counter += 1;
                    NavigationService.Navigate(new Page5());
                }
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }
        private void nextFromOne(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\asala\OneDrive\Рабочий стол\EnProj\text_quest\bin\Debug\net8.0-windows\mid.wav");
            player.Play();
            CounterTransfer.counter += 2;
            _timer.Stop();
            NavigationService.Navigate(new Page5());
        }
        private void nextFromTwo(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\asala\OneDrive\Рабочий стол\EnProj\text_quest\bin\Debug\net8.0-windows\good.wav");
            player.Play();
            CounterTransfer.counter += 3;
            _timer.Stop();
            NavigationService.Navigate(new Page5());
        }
        private void nextFromThree(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\asala\OneDrive\Рабочий стол\EnProj\text_quest\bin\Debug\net8.0-windows\bad.wav");
            player.Play();
            CounterTransfer.counter += 1;
            _timer.Stop();
            NavigationService.Navigate(new Page5());
        }
    }
}
