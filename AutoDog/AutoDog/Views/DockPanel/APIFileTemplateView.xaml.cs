﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoDog.Views
{
    /// <summary>
    /// ApiFileTemplateView.xaml 的交互逻辑
    /// </summary>
    public partial class APIFileTemplateView : UserControl
    {
        public APIFileTemplateView()
        {
            InitializeComponent();
        }

        private void AddParams_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RunAPI_Click(object sender, RoutedEventArgs e)
        {
            WebBrowser wb = new WebBrowser();
            wb.Navigate(myUrl.Text);
        }

        private void myFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
