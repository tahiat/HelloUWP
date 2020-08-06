﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hamburger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Financial));
            BackButton.Visibility = Visibility.Collapsed;
            FinancialItem.IsSelected = true;
        }

        private void StackPanel_Holding(object sender, HoldingRoutedEventArgs e)
        {

        }

        private void HamburgerBtn_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void PanelList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FinancialItem.IsSelected)
            {
                MyFrame.Navigate(typeof(Financial));
                PageTitle.Text = "Financial";
                BackButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                MyFrame.Navigate(typeof(Food));
                PageTitle.Text = "Food";
                BackButton.Visibility = Visibility.Visible;
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                FinancialItem.IsSelected = true;
            }

        }
    }
}
