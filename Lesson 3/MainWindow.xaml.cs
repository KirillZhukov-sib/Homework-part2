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

namespace Lesson_3
{    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void FacultyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FacultyComboBox.SelectedItem == null) return;

            string selectedFaculty = (FacultyComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            TopicsListBox.Items.Clear();
            switch (selectedFaculty)
            {
                case "C#":
                    TopicsListBox.Items.Add("Графика");
                    TopicsListBox.Items.Add("Операторы");
                    TopicsListBox.Items.Add("Операции");
                    TopicsListBox.Items.Add("Многопоточность");
                    TopicsListBox.Items.Add("Asynk/Await");
                    break;

                case "Python":
                    TopicsListBox.Items.Add("Веб-разработка");
                    TopicsListBox.Items.Add("Data Science");
                    TopicsListBox.Items.Add("Машинное обучение");
                    TopicsListBox.Items.Add("Django");
                    TopicsListBox.Items.Add("NumPy");
                    break;

                case "Java":
                    TopicsListBox.Items.Add("Spring Framework");
                    TopicsListBox.Items.Add("Android разработка");
                    TopicsListBox.Items.Add("Hibernate");
                    TopicsListBox.Items.Add("Maven");
                    TopicsListBox.Items.Add("JUnit");
                    break;
            }
        }

        private void record_Click(object sender, RoutedEventArgs e)
        {
            if (!check.IsChecked ?? false)
            {
                MessageBox.Show("Ошибка: необходимо согласиться на обработку персональных данных!", "Ошибка",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }

            var selectedCourses = TopicsListBox.SelectedItems
            .Cast<string>()
            .ToList();

            string message = $"Профиль сохранен!\n\n" +
                             $"Имя: {TextName.Text}\n" +
                             $"Факультет: {FacultyComboBox.Text}\n" +
                             $"Выбранные курсы: {string.Join(", ", selectedCourses)}\n"  +
                             $"Согласие на рассылку: {(check.IsChecked == true ? "Да" : "Нет")}";

            MessageBox.Show(message, "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}