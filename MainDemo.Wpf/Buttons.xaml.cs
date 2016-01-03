using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MaterialDesignDemo.Domain;

namespace MaterialDesignDemo
{
    /// <summary>
    /// Interaction logic for Buttons.xaml
    /// </summary>
    public partial class Buttons : UserControl
    {
        public Buttons()
        {
            //InitializeComponent();

            FloatingActionDemoCommand = new AnotherCommandImplementation(Execute);
        }

        public ICommand FloatingActionDemoCommand { get; }

        private void Execute(object o)
        {
            Console.WriteLine("Floating action button command. - " + (o ?? "NULL").ToString());
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
	    {
            Console.WriteLine("Just checking we haven't suppressed the button.");
		}
    }
}
