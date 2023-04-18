using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
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

namespace WPFalibaba
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Chart1.Visibility = Visibility.Hidden;
            Chart2.Visibility = Visibility.Hidden;
            Chart3.Visibility = Visibility.Hidden;
            Chart4.Visibility = Visibility.Hidden;
            Chart5.Visibility = Visibility.Hidden;
            Chart6.Visibility = Visibility.Hidden;
            Chart7.Visibility = Visibility.Hidden;
            Chart8.Visibility = Visibility.Hidden;
            Chart9.Visibility = Visibility.Hidden;
            Chart10.Visibility = Visibility.Hidden;
            switch (ChartSelectBox.SelectedValue.ToString())
            {
                case ("Road Steps"): Chart1.Visibility = Visibility.Visible; break;
                case ("Road Duration"): Chart2.Visibility = Visibility.Visible; break;
                case ("Road Speed"): Chart3.Visibility = Visibility.Visible; break;
                case ("Road Distance"): Chart4.Visibility = Visibility.Visible; break;
                case ("Road Calories"): Chart5.Visibility = Visibility.Visible; break;
                case ("Forest Steps"): Chart6.Visibility = Visibility.Visible; break;
                case ("Forest Duration"): Chart7.Visibility = Visibility.Visible; break;
                case ("Forest Speed"): Chart8.Visibility = Visibility.Visible; break;
                case ("Forest Distance"): Chart9.Visibility = Visibility.Visible; break;
                case ("Forest Calories"): Chart10.Visibility = Visibility.Visible; break;
            }
        }
    }
}
