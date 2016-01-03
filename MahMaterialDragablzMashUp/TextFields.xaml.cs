using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace MahAppsDragablzDemo
{
	/// <summary>
	/// Interaction logic for Fields.xaml
	/// </summary>
	public partial class TextFields : UserControl
	{
		public TextFields()
		{
			InitializeComponent();
			DataContext = new TextFieldsViewModel();
		}
	}

	public class TextFieldsViewModel : INotifyPropertyChanged
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
