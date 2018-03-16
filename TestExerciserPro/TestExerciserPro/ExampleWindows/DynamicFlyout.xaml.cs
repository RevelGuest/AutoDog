﻿using System.Windows;

namespace TestExerciserPro.ExampleWindows {
    /// <summary>
    /// Interaction logic for DynamicFlyout.xaml
    /// </summary>
    public partial class DynamicFlyout {
        public DynamicFlyout() {
            this.InitializeComponent();
        }

        private void CloseFlyoutClick(object sender, RoutedEventArgs e)
        {
            this.IsOpen = false;
        }
    }
}