﻿using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace MaterialDesignDemo
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void GitHubButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/ButchersBoy/MaterialDesignInXamlToolkit");
        }

        private void TwitterButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://twitter.com/James_Willock");
        }

        private void ChatButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://gitter.im/ButchersBoy/MaterialDesignInXamlToolkit");
        }

        private void EmailButton_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("mailto://james@dragablz.net");
        }
    }
}
