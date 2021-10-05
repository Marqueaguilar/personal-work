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

namespace WpfApp1
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
            // http://id.gd/timespan
            //Days.Hours:Minuits:Seconds.Milliseconds

            
            TimeSpan myTimeSpan = TimeSpan.Parse("1.6:35:22.6");
            
            DateTime myBirthday = DateTime.Parse("10/17/2004");
            
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            // LabelResult.Content = myAge.Hours.ToString();

            LabelResult.Content = myAge.TotalDays.ToString();

        }
    }
}
