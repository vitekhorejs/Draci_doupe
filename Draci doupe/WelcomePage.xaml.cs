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
    /// Interakční logika pro WelcomePage.xaml
    /// </summary>
    partial class WelcomePage : Page
    {
        public static Player vito = new Player();
        
        public WelcomePage()
        {
            InitializeComponent();
            vito.HP = 100;
            vito.Level = 1;
            vito.Name = "Vito";
            vito.Strenght = 1;
            vito.Vitality = 1;
            vito.Defense = 1;
            vito.Attack = 10;
            
        }

        private void start(object sender, RoutedEventArgs e)
        {
            
            this.NavigationService.Navigate(new MissionPage());
        }
    }
}
