﻿using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using MaterialDesignDemo.Domain;
using MaterialDesignThemes.Wpf;

namespace MaterialDesignDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UIElement_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MenuToggleButton.IsChecked = false;
        }

        private async void MenuPopupButton_OnClick(object sender, RoutedEventArgs e)
        {
            var sampleMessageDialog = new SampleMessageDialog
            {
                Message = {Text = ((ButtonBase) sender).Content.ToString()}
            };

            await DialogHost.Show(sampleMessageDialog, "RootDialog");            
        }
    } 
}
