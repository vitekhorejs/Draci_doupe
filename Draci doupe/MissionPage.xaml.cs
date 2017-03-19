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
    /// Interakční logika pro Mission.xaml
    /// </summary>
    public partial class MissionPage : Page
    {
        public MissionPage()
        {
            InitializeComponent();
            //List<Mission> missions = List<Mission>();
            //Mission_adding.Mission();
            //object nneco = Mission_adding.Mission();
            //listView.ItemsSource = nneco{};
            //listView.ItemsSource = Mission_adding;
            /*Mission_adding mission_adding = new Mission_adding();
            object obj = mission_adding;*/
            //listView.ItemsSource = obj;
            List<string> misse = new List<string>();
            for (int x = 0; x < 4; x++)
            {
                Mission mise = new Mission(x);
                //listView.Items.Add(mise.Name_Mission);
                misse.Add(mise.Name_Mission);
                
            }
            listView.ItemsSource = misse;
            DataContext = this;

        }
        public Player player1 = new Player();
        public void button_Click(object sender, RoutedEventArgs e)
        {
            //Player.player1 = new Player(textBox.Text);
            //IPlayer player1 = Player.player1;
            
           /* player1.HP = 100;
            player1.Level = 1;
            //player1.Stamina = 1;
            player1.Defense = 1;
            player1.Strenght = 1;
            player1.Vitality = 1;
            FightPage FightPage = new FightPage();*/
            /*if (textBox.Text != "" && textBox.Text != null)
            {
                this.NavigationService.Navigate(FightPage);
            }*/

            //List<Mission> missions = new List<Mission>();

            /*foreach (var item in BAL.ListItems())
            {
                lvNewData.Items.Add(item.Name);
            }*/

            
            //listView.DataBind();
        }

        private void listViewItem_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
           //MessageBox.Show("Neplatné rodné číslo.", "Upozornění", MessageBoxButton.OK, MessageBoxImage.Information);
            //ListViewItem item = sender as ListViewItem;
            object obj = sender;
            //object obj = item.Content;
            
           
            DisplayMissionDetails(obj);
        }

        private void DisplayMissionDetails(object obj)
        {
           MissionDescription.Content = obj;
            
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

        private void shop_button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ShopPage());
        }
    }
}
