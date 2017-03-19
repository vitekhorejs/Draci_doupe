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

namespace Draci_doupe
{
    /// <summary>
    /// Interakční logika pro CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : Page
    {
        public CharacterPage()
        {
            InitializeComponent();
        }
        private void mission_button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MissionPage());
        }

        private void equipment_button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EquipmentPage());
        }

        private void stat_button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new StatPage());
        }

        private void shop_button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ShopPage());
        }

    }
}
