﻿using System;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;

namespace MaterialDesignDemo
{
    /// <summary>
    /// Interaction logic for Dialogs.xaml
    /// </summary>
    public partial class Dialogs : UserControl
    {
        public Dialogs()
        {
            InitializeComponent();
        }

        private void Sample1_DialogHost_OnDialogClosing(object sender, DialogClosingEventArgs eventArgs)
        {
            Console.WriteLine("SAMPLE 1: Closing dialog with parameter: " + (eventArgs.Parameter ?? ""));

            //you can cancel the dialog close:
            //eventArgs.Cancel();

            if (!Equals(eventArgs.Parameter, true)) return;
            
            if (!string.IsNullOrWhiteSpace(FruitTextBox.Text))
                FruitListBox.Items.Add(FruitTextBox.Text.Trim());
        }

        private void Sample2_DialogHost_OnDialogClosing(object sender, DialogClosingEventArgs eventArgs)
        {
            Console.WriteLine("SAMPLE 2: Closing dialog with parameter: " + (eventArgs.Parameter ?? ""));
        }
    }
}
