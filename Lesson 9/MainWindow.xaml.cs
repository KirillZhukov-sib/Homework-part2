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

namespace Lesson_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stack<Brush> _colorHistory = new Stack<Brush>();
        private Brush _currentColor;

        public MainWindow()
        {
            InitializeComponent();
            CurrentColor = Brushes.White; // Инициализация начального цвета
        }

        private void ChangeColorExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            var random = new Random();
            CurrentColor = new SolidColorBrush(Color.FromRgb(
                (byte)random.Next(256),
                (byte)random.Next(256),
                (byte)random.Next(256)));
        }

        public Brush CurrentColor
        {
            get => _currentColor;
            set
            {
                _currentColor = value;
                if (_colorHistory.Count == 0 || _colorHistory.Peek() != value)
                {
                    _colorHistory.Push(value);
                }
                Dock.Background = _currentColor;
            }
        }

        private void UndoExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (_colorHistory.Count > 1)
            {
                _colorHistory.Pop(); // Удаляем текущий цвет
                CurrentColor = _colorHistory.Peek(); // Берем предыдущий
            }
        }

        private void UndoCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _colorHistory.Count > 1;
        }
    }
}