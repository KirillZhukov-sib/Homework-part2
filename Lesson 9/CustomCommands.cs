using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace Lesson_9
{
    internal class CustomCommands
    {
        public static RoutedUICommand ChangeColor { get; set; }
        static CustomCommands()
        {
            InputGestureCollection inputGestureCollection = new InputGestureCollection();
            inputGestureCollection.Add(new KeyGesture(Key.C, ModifierKeys.Control, "Ctrl+C"));

            ChangeColor = new RoutedUICommand("Change Color", "ChangeColor", typeof(CustomCommands), inputGestureCollection);
        }
    }
}