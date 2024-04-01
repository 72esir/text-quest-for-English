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

            if (counter > 18)
            {
                resultTxt.Text = "Later the threats stopped. Company management reported that the initial problems were a test, but that the real dangers later emerged. Thanks to your actions and professionalism, the company has avoided a serious data breach, and your reputation in the cybersecurity department is enhanced. You will also receive a bonus.";

            }
            else if (counter < 19 && counter > 10)
            {
                resultTxt.Text = "You completed your job without major incidents. Company management reported you performed satisfactorily on most of the tests, but your response to threats was not effective enough and you were downgraded 25%.";
            }
            else if (counter < 11)
            {
                resultTxt.Text = "Your mistakes in responding to cyber threats have had serious consequences for your company and your career. You've suffered serious losses due to a data breach. As well as being accused of a data breach, you now owe the company a hefty sum that will take years to pay back. You're homeless.";
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
