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
        public string enemy_name;
        public int enemy_hp;
        public int enemy_strenght;
        public int enemy_defense;
        public int enemy_attack;

        private static List<Mission> Mission()
        {
            List<Mission> missions = new List<Mission>();
            //ObservableCollection<Mission> dataList = new ObservableCollection<Mission>();
            missions.Add(new Mission { Done = false, Level = 1, Text_Mission = "povídání k misi", Mission_description = "musis tohle", Enemy_HP = 50, Enemy_Attack = 50, Enemy_defense = 5, Enemy_name = "pan Chu", Enemy_Strenght = 5, Name_Mission = "zabij pana Chu", Reward = 100 });
            missions.Add(new Mission { Done = true, Level = 2, Text_Mission = "další povídání k misi", Mission_description = "a tady musis zas tohle", Enemy_HP = 40, Enemy_Attack = 60, Enemy_defense = 4, Enemy_name = "irčan", Enemy_Strenght = 4, Name_Mission = "odstran iracana z cesty", Reward = 500 });
            return missions;
        }
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
            /* List<string> misse = new List<string>();
             for (int x = 0; x < 4; x++)
             {
                 Mission mise = new Mission(x);
                 //listView.Items.Add(mise.Name_Mission);
                 misse.Add(mise.Name_Mission);

             }
             listView.ItemsSource = misse;
             DataContext = this;*/
            listView.ItemsSource = Mission();

        }
        
        public void button_Click(object sender, RoutedEventArgs e)
        {
            Player enemy = new Player();
            enemy.HP.Equals(enemy_hp);
            enemy.Attack = enemy_attack;
            enemy.Defense = enemy_defense;
            enemy.Name = enemy_name;
            enemy.Strenght = enemy_strenght;

            this.NavigationService.Navigate(new FightPage(WelcomePage.vito, enemy));
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
            //ListViewItem item = sender as ListViewItem;
            //Mission neco = sender;

            
            //object obj = sender;
            ListViewItem neco = (ListViewItem)sender;
            Mission poslat = (Mission)neco.Content;
            //object obj = item.Content;


            DisplayMissionDetails(poslat);
            
        }

        private void DisplayMissionDetails(Mission obj)
        {
           MissionDescription.Content = obj.Mission_description;
            MissionEarn.Content = obj.Reward;
            //Mission mission = obj;
            enemy_attack = obj.Enemy_Attack;
            enemy_defense = obj.Enemy_defense;
            enemy_hp = obj.Enemy_HP;
            enemy_name = obj.Enemy_name;
            enemy_strenght = obj.Enemy_Strenght;
            
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
