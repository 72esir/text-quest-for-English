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
    /// Interaction logic for autors.xaml
    /// </summary>
    public partial class autors : Page
    {
        public autors()
        {
            InitializeComponent();
            topic.Text = "Developed by";
            mainPart.Text = "First year students, group PRI-104 \n Salamatin Aleksey, \n Dudarow Dmitrii";
            lincksPart.Text = "Social media links: " + Environment.NewLine + "Aleksey: clck.ru/39trxd" + Environment.NewLine + "Dmitrii: clck.ru/39tsg7";
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page4());
        }
    }
}
