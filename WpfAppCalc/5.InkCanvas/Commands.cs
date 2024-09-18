using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _5.InkCanvas
{
    internal class Commands
    {
        public static RoutedCommand Exit { get; set; }

        static Commands() 
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.F4, ModifierKeys.Alt, "Alt+F4"));
            Exit = new RoutedCommand("Exit", typeof(Commands), inputs);
        }
    }
}
