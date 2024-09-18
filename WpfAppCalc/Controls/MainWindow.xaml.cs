using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
            if (textInBox != null)
            {
                textInBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textInBox != null)
            {
                textInBox.Foreground = Brushes.Red;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textInBox != null)
            {
                textInBox.FontFamily = new FontFamily(((sender as ComboBox).SelectedItem).ToString());
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (textInBox != null)
            {
                textInBox.FontSize = double.Parse(((sender as ComboBox).SelectedItem).ToString(), CultureInfo.InvariantCulture);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textInBox.FontWeight != FontWeights.Bold)
            {
                textInBox.FontWeight = FontWeights.Bold;
            }
            else
            {
                textInBox.FontWeight = FontWeights.Normal;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textInBox.FontStyle != FontStyles.Italic)
            {
                textInBox.FontStyle = FontStyles.Italic;
            }
            else
            {
                textInBox.FontStyle = FontStyles.Normal;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textInBox.TextDecorations != TextDecorations.Underline)
            {
                textInBox.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                textInBox.TextDecorations = null;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Текстовые файлы *.txt|*.txt|Все файлы *.*|*.*";
            if (dialog.ShowDialog()  == true)
            {
                textInBox.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Текстовые файлы *.txt|*.txt|Все файлы *.*|*.*";
            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, textInBox.Text);
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
