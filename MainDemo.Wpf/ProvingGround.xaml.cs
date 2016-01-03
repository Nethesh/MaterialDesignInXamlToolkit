using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignDemo.Domain;

namespace MaterialDesignDemo
{
    /// <summary>
    /// Interaction logic for ProvingGround.xaml
    /// </summary>
    public partial class ProvingGround : UserControl
    {
        public ProvingGround()
        {
            InitializeComponent();
	        DataContext = new ProvingGroundViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/James_Willock");

        }
    }

    public class ProvingGroundViewModel : INotifyPropertyChanged
	{
		private string _name;
        private readonly ObservableCollection<SelectableViewModel> _items = CreateData();


        public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				OnPropertyChanged();
			}
		}

        public ObservableCollection<SelectableViewModel> Items
        {
            get { return _items; }
        }

        private static ObservableCollection<SelectableViewModel> CreateData()
        {
            return new ObservableCollection<SelectableViewModel>
            {
                new SelectableViewModel
                {
                    Code = 'M',
                    Name = "Material Design",
                    Description = "Material Design in XAML Toolkit"
                },
                new SelectableViewModel
                {
                    Code = 'D',
                    Name = "Dragablz",
                    Description = "Dragablz Tab Control"
                },
                new SelectableViewModel
                {
                    Code = 'P',
                    Name = "Predator",
                    Description = "If it bleeds, we can kill it"
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			//PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
