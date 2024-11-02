using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _14.DataTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name = "Tomato",
                Category = Categories.Еда,
                Price = 123.2f,
                ImagePath = "Images/Tomato.jpg"
            });
            products.Add(new Product()
            {
                Name = "Cucumber",
                Category = Categories.Еда,
                Price = 88.8f,
                ImagePath = "Images/cucumber.png"
            });
            products.Add(new Product()
            {
                Name = "Smartphone",
                Category = Categories.Техника,
                Price = 10000f,
                ImagePath = "Images/phone.jpg"
            });
            products.Add(new Product()
            {
                Name = "Washing machine",
                Category = Categories.Техника,
                Price = 39999f,
                ImagePath = "Images/washing.jpg"
            });
            lstBox.ItemsSource = products;
        }
    }

    public enum Categories
    {
        Еда,
        Техника
    }

    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string ImagePath { get; set; }
        public Categories Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class PathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((Categories)value == Categories.Техника)
            {
                return "Images/tech.jpg";
            }

            return "Images/vegetables.jpg";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
