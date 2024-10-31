using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
            List<string> styles = new List<string>
            {
                "Light",
                "Dark"
            };
            StyleBox.ItemsSource = styles;
            StyleBox.SelectionChanged += StyleBox_SelectionChanged;
            StyleBox.SelectedIndex = 0;
        }

        private void StyleBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Uri resourceLocator = new Uri("Light.xaml", UriKind.Relative);
            if(StyleBox.SelectedIndex == 1)
            {
                resourceLocator = new Uri("Dark.xaml", UriKind.Relative);
            }

            ResourceDictionary resource = Application.LoadComponent(resourceLocator) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);        }

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

    static public class CustomFont
    {
        public static List<int> CustomSize
        {
            get { return new List<int> { 12, 14, 16 }; }
        }

        public static List<string> CustomFamily
        {
            get { return new List<string> { "Arial", "Times New Roman", "Verdana" }; }
        }
    }
}
