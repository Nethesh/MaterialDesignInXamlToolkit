﻿using System;
using System.Windows;
using System.Windows.Input;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace MahAppsDragablzDemo
{
    public class DialogsViewModel
    {
        public ICommand ShowInputDialogCommand { get; }

        public ICommand ShowProgressDialogCommand { get; }

        public ICommand ShowLeftFlyoutCommand { get; }

        private ResourceDictionary DialogDictionary = new ResourceDictionary() { Source = new Uri("pack://application:,,,/MaterialDesignThemes.MahApps;component/Themes/MaterialDesignTheme.MahApps.Dialogs.xaml") };

        public DialogsViewModel()
        {
            ShowInputDialogCommand = new AnotherCommandImplementation(_ => InputDialog());
            ShowProgressDialogCommand = new AnotherCommandImplementation(_ => ProgressDialog());
            ShowLeftFlyoutCommand = new AnotherCommandImplementation(_ => ShowLeftFlyout());
        }

        public Flyout LeftFlyout { get; set; }

        private void InputDialog()
        {
            var metroDialogSettings = new MetroDialogSettings
            {
                CustomResourceDictionary = DialogDictionary,
                NegativeButtonText = "CANCEL",
                SuppressDefaultResources = true
            };

            DialogCoordinator.Instance.ShowInputAsync(this, "MahApps Dialog", "Using Material Design Themes", metroDialogSettings);
        }

        private void ProgressDialog()
        {
            var metroDialogSettings = new MetroDialogSettings
            {
                CustomResourceDictionary = DialogDictionary,
                NegativeButtonText = "CANCEL",
                SuppressDefaultResources = true
            };

            DialogCoordinator.Instance.ShowProgressAsync(this, "MahApps Dialog", "Using Material Design Themes (WORK IN PROGRESS)", true, metroDialogSettings);
        }

        private void ShowLeftFlyout()
        {
            ((MainWindow)Application.Current.MainWindow).LeftFlyout.IsOpen = true;
        }
    }
}
