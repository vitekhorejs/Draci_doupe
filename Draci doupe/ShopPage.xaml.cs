using System;
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
    /// Interakční logika pro ShopPage.xaml
    /// </summary>
    public partial class ShopPage : Page
    {
        public ShopPage()
        {
            InitializeComponent();
        }

        private void mission_button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MissionPage());
        }

        private void character_button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CharacterPage());
        }

        private void equipment_button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EquipmentPage());
        }

        private void stat_button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new StatPage());
        }
    }
}
