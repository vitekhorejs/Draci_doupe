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
    /// Interakční logika pro MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void button_Click(object sender, RoutedEventArgs e)
        {
            Player.player1 = new Player(textBox.Text);
            IPlayer player1 = Player.player1;
            player1.HP = 100;
            player1.Level = 1;
            player1.Stamina = 1;
            player1.Defense = 1;
            player1.Strenght = 1;
            player1.Vitality = 1;
            FightPage FightPage = new FightPage();
            if (textBox.Text != "" && textBox.Text != null)
            {
                this.NavigationService.Navigate(FightPage);
            }
            //https://developer.xamarin.com/guides/android/application_fundamentals/notifications/local_notifications_in_android/
            //https://forums.xamarin.com/discussion/62135/background-task-running-with-async-await-suggested-approach
            //https://developer.xamarin.com/guides/android/application_fundamentals/services/

        }
    }
}
