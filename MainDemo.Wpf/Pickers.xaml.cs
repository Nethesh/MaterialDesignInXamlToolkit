using System.Windows.Controls;
using MaterialDesignThemes.Wpf;

namespace MaterialDesignDemo
{
    /// <summary>
    /// Interaction logic for Pickers.xaml
    /// </summary>
    public partial class Pickers : UserControl
    {
        public Pickers()
        {
            InitializeComponent();
            FutureDatePicker.BlackoutDates.AddDatesInPast();
        }

        public void CalendarDialogOpenedEventHandler(object sender, DialogOpenedEventArgs eventArgs)
        {
            Calendar.SelectedDate = ((PickersViewModel)DataContext).Date;
        }

        public void CalendarDialogClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            if (!Equals(eventArgs.Parameter, "1")) return;

            if (!Calendar.SelectedDate.HasValue)
            {
                eventArgs.Cancel();
                return;
            }

            ((PickersViewModel)DataContext).Date = Calendar.SelectedDate.Value;
        }

        public void ClockDialogOpenedEventHandler(object sender, DialogOpenedEventArgs eventArgs)
        {
            Clock.Time = ((PickersViewModel) DataContext).Time;
        }

        public void ClockDialogClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            if (Equals(eventArgs.Parameter, "1"))
                ((PickersViewModel)DataContext).Time = Clock.Time;
        }
    }
}
