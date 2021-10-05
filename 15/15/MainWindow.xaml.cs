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

namespace _15
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
            // https://is.gd/timespan
            //Days.Hours;Minutes:Seconds.Milliseconds

            TimeSpan myTimeSpan = TimeSpan.Parse("1.6:35:22.6");

            DateTime myBirthday = DateTime.Parse("10/17/2004");

            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

             = myAge

        }
    }
}
