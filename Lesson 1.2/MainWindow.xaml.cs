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

namespace Lesson_1._2
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
        int start = 2;
        private void Push_Click(object sender, RoutedEventArgs e)
        {
            start = (start + 1) % 3;

            Red.Fill = Brushes.Gray;
            Yellow.Fill = Brushes.Gray;
            Green.Fill = Brushes.Gray;

            switch (start)
            {
                case 0: // Красный
                    Red.Fill = Brushes.Red;
                    break;
                case 1: // Желтый
                    Yellow.Fill = Brushes.Yellow;
                    break;
                case 2: // Зеленый
                    Green.Fill = Brushes.Green;
                    break;
            }
        }
    }
}