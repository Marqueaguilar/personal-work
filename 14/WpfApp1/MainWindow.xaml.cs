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
            //DateTime myDate = DateTime.Now;

            //LabelDate.Content = myDate.ToString();
            //LabelDate.Content = myDate.ToLongDateString();
            //LabelDate.Content = myDate.ToLongTimeString();
            //LabelDate.Content = myDate.ToShortDateString();
            //LabelDate.Content = myDate.ToShortTimeString();

            //LabelDate.Content = myDate.AddDays(2).ToString();
            //LabelDate.Content = myDate.AddMonths(-2).ToString();

            //LabelDate.Content = myDate.IsDaylightSavingTime().ToString();
            //LabelDate.Content = myDate.DayOfWeek.ToString();

            //DateTime myDate = DateTime.Parse("12/09/1963");

            DateTime myDate = new DateTime(1963, 12, 9);
            LabelDate.Content = myDate.ToString();







        }
    }
}
