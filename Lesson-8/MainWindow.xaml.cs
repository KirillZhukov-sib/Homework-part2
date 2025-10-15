using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products = new ObservableCollection<Product>();
        public MainWindow()
        {
            InitializeComponent();

            products.Add(new Product()
            {
                Name = "Картофель",
                Price = 123,
                PicturePath= "Images/potato.jpg",
                Category = ProductCategory.Food,
            });
            products.Add(new Product()
            {
                Name = "Стиральная машина",
                Price = 43800,
                PicturePath= "Images/fridge.png",
                Category = ProductCategory.Appliances,

            }); 
            products.Add(new Product()
            {
                Name = "Сэндвич",
                Price = 123,
                PicturePath= "Images/sandwich.jpg",
                Category = ProductCategory.Food,

            });
            lstBox.ItemsSource = products;
        }
    }
}