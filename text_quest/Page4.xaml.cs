using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        int counter = CounterTransfer.counter;
        public Page4()
        {
            InitializeComponent();

            if (counter > 4)
            {
                resultTxt.Text = "good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good goodgood good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good good goo good good good good good good good good";

            }
            else if (counter < 5 && counter > 2)
            {
                resultTxt.Text = "midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midlemidle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midlemidle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle midle";

            }
            else if (counter < 3)
            {
                resultTxt.Text = "bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad badbad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bbad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad badbad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad babad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad bad ba";

            }
        }
        private void Close(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void Us(object sender, RoutedEventArgs e)
        {

        }
        private void Restart(object sender, RoutedEventArgs e)
        {
            CounterTransfer.counter = 0;
            MainWindow back = new MainWindow();
            back.Show();
            Window.GetWindow(this).Close();
        }
    }
}
