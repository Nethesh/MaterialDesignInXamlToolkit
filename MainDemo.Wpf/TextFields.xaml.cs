using System.Windows;
using System.Windows.Controls;
using MaterialDesignDemo.Domain;

namespace MaterialDesignDemo
{
    /// <summary>
    /// Interaction logic for TextFields.xaml
    /// </summary>
    public partial class TextFields : UserControl
    {
        public TextFields()
        {
            InitializeComponent();	        
			DataContext = new TextFieldsViewModel();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {            
        }		
    }


}
