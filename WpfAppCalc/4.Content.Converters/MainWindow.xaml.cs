using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace _4.Content.Converters
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
            if (!string.IsNullOrEmpty(tbCourseUsd.Text) && !string.IsNullOrEmpty(tbSummUsd.Text))
            {
                tbResultUSD.Text = (float.Parse(tbCourseUsd.Text, CultureInfo.InvariantCulture) * float.Parse(tbSummUsd.Text, CultureInfo.InvariantCulture)).ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCourseEuro.Text) && !string.IsNullOrEmpty(tbSummEuro.Text))
            {
                tbResultEuro.Text = (float.Parse(tbCourseEuro.Text, CultureInfo.InvariantCulture) * float.Parse(tbSummEuro.Text, CultureInfo.InvariantCulture)).ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCourseGrivna.Text) && !string.IsNullOrEmpty(tbSummGrivna.Text))
            {
                tbResultGrivna.Text = (float.Parse(tbCourseGrivna.Text, CultureInfo.InvariantCulture) * float.Parse(tbSummGrivna.Text, CultureInfo.InvariantCulture)).ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCourseDrama.Text) && !string.IsNullOrEmpty(tbSummDrama.Text))
            {
                tbResultDrama.Text = (float.Parse(tbCourseDrama.Text, CultureInfo.InvariantCulture) * float.Parse(tbSummDrama.Text, CultureInfo.InvariantCulture)).ToString();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbInch.Text)) tbResultInch.Text = (float.Parse(tbInch.Text, CultureInfo.InvariantCulture) * 0.0254f).ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMile.Text)) tbResultMile.Text = (float.Parse(tbMile.Text, CultureInfo.InvariantCulture) * 1609.34f).ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbFeet.Text)) tbResultFeet.Text = (float.Parse(tbFeet.Text, CultureInfo.InvariantCulture) * 0.3048f).ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbVersta.Text)) tbResultVersta.Text = (float.Parse(tbVersta.Text, CultureInfo.InvariantCulture) * 1066.8f).ToString();
        }
    }
}
