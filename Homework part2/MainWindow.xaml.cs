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

namespace Homework_part2
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
            try
            {
                double num1 = Convert.ToDouble(Number1TextBox.Text);
                double num2 = Convert.ToDouble(Number2TextBox.Text);

                double res = 0;

                Button button = (Button)sender;
                switch (button.Content)
                {
                    case "+":
                        res = num1 + num2;
                        break;
                    case "-":
                        res = num1 - num2;
                        break;
                    case "*":
                        res = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        { throw new InvalidOperationException("Деление на 0"); }
                        res = num1 / num2;
                        break;
                }
                Result.Text = $"Результат: {res}";
            }
            catch (Exception ex)
            {
                Result.Text = ex.Message;
            }
        }
        
    }
}