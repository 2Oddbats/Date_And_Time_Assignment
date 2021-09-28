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

namespace Date_And_Time_Assignment
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

        private void buttonGo_Click(object sender, RoutedEventArgs e)
        {
            //DateTime myDate = DateTime.Now;

            //labelResult.Content = myDate.ToString();
            //labelResult.Content = myDate.ToLongDateString();
            //labelResult.Content = myDate.ToLongTimeString();
            //labelResult.Content = myDate.ToShortDateString();
            //labelResult.Content = myDate.ToShortTimeString();

            //labelResult.Content = myDate.AddDays(2).ToString();
            //labelResult.Content = myDate.AddMonths(-2).ToString();

            //labelResult.Content = myDate.IsDaylightSavingTime().ToString();
            //labelResult.Content = myDate.DayOfWeek.ToString();

            //DateTime myDate = DateTime.Parse("12/09/1963");

            //DateTime myDate = new DateTime(1963, 12, 9);
            //labelResult.Content = myDate.ToString();


        }
    }
}
