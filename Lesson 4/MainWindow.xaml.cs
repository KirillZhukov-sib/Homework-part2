using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lesson_4
{
    public class ToggleButton : Button
    {
        public static readonly DependencyProperty IsToggledProperty =
            DependencyProperty.Register(
                "IsToggled",
                typeof(bool),
                typeof(ToggleButton),
                new PropertyMetadata(false, OnIsToggledChanged));

        public bool IsToggled
        {
            get { return (bool)GetValue(IsToggledProperty); }
            set { SetValue(IsToggledProperty, value); }
        }

        public ToggleButton()
        {
            UpdateAppearance();

            this.Click += OnToggleButtonClick;
        }

        private void OnToggleButtonClick(object sender, RoutedEventArgs e)
        {
            IsToggled = !IsToggled;
        }

        private static void OnIsToggledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = d as ToggleButton;
            button?.UpdateAppearance();
        }

        private void UpdateAppearance()
        {
            if (IsToggled)
            {
                this.Background = new SolidColorBrush(Colors.Green);
                this.Content = "ON";
                this.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                this.Background = new SolidColorBrush(Colors.Red);
                this.Content = "OFF";
                this.Foreground = new SolidColorBrush(Colors.White);
            }
        }
    }
}