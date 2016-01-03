using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MaterialDesignDemo
{
    public class PickersViewModel : INotifyPropertyChanged
    {
        private DateTime _date;
        private DateTime _time;

        public PickersViewModel()
        {
            Date = DateTime.Now;
            Time = DateTime.Now;
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        public DateTime Time
        {
            get { return _time; }
            set
            {
                _time = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
