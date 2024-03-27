using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Controls
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBlock != null)
            {
                textBlock.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBlock != null)
            {
                textBlock.Foreground = Brushes.Red;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textBlock != null)
            {
                textBlock.FontFamily = new FontFamily(((sender as ComboBox).SelectedItem as TextBlock).Text);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (textBlock != null)
            {
                textBlock.FontSize = double.Parse(((sender as ComboBox).SelectedItem as TextBlock).Text, CultureInfo.InvariantCulture);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock.FontWeight != FontWeights.Bold)
            {
                textBlock.FontWeight = FontWeights.Bold;
            }
            else
            {
                textBlock.FontWeight = FontWeights.Normal;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBlock.FontStyle != FontStyles.Italic)
            {
                textBlock.FontStyle = FontStyles.Italic;
            }
            else
            {
                textBlock.FontStyle = FontStyles.Normal;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBlock.TextDecorations != TextDecorations.Underline)
            {
                textBlock.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                textBlock.TextDecorations = null;
            }
        }
    }
}
