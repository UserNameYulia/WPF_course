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

namespace _5.InkCanvas
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
            if (inkCanvas != null)
            {
                inkCanvas.Background = Brushes.White;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (inkCanvas != null)
            {
                inkCanvas.Background = Brushes.Red;
            }
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            if (inkCanvas != null)
            {
                inkCanvas.Background = Brushes.Blue;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Картинки *.jpg|*.jpg|Все файлы *.*|*.*";
            if (dialog.ShowDialog() == true)
            {
                ImageBrush brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri(dialog.FileName, UriKind.Relative));
                inkCanvas.Background = brush;
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            RenderTargetBitmap bmp = new RenderTargetBitmap((int)inkCanvas.ActualWidth, (int)inkCanvas.ActualHeight, 100.0, 100.0, PixelFormats.Default);
            bmp.Render(inkCanvas);

            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bmp));

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Картинки *.jpg|*.jpg|Все файлы *.*|*.*";
            if (dialog.ShowDialog() == true)
            {
                FileStream stream = File.Create(dialog.FileName);
                encoder.Save(stream);
                stream.Close();
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (inkCanvas != null)
            {
                inkCanvas.Opacity = slider.Value / 100;
            }
        }

        private int i = 0;

        private void inkCanvas_StrokeCollected(object sender, InkCanvasStrokeCollectedEventArgs e)
        {
            Random rnd = new Random();
            inkCanvas.Strokes[i++].DrawingAttributes.Color =
                Color.FromArgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));

        }

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MenuItem_Click(sender, e);
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MenuItem_Click_1(sender, e);
        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
