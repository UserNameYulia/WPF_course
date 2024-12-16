using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _19.MVVM.ViewModel
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel() 
        {
            CalculateCommand = new RelayCommand(OnCalculateCommandExecute, CanCalculateCommandExecuted);
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }

        private double length;
        public double Length
        {
            get => length;
            set
            {
                length = value;
                OnPropertyChanged();
            }
        }

        public ICommand CalculateCommand { get; }
        private void OnCalculateCommandExecute(object parameter) 
        {
            Length = 2 * radius * Math.PI;
        }

        private bool CanCalculateCommandExecuted(object parameter) 
        {
            return true;
        }
    }
}
