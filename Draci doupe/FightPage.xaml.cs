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
using System.ComponentModel;

namespace Draci_doupe
{
    /// <summary>
    /// Interakční logika pro FightPage.xaml
    /// </summary>
    public partial class FightPage : Page, INotifyPropertyChanged
    {
        //public IPlayer player1 { get; set; }
        private string _enemy_name;
        public string name_enemy
        {
            get { return _enemy_name; }
            set
            {
                _enemy_name = value;
                OnPropertyChanged("name_enemy");
            }
        }

        private int _enemy_hp;
        public int hp_enemy
        {
            get { return _enemy_hp; }
            set
            {
                _enemy_hp = value;
                OnPropertyChanged("hp_enemy");
            }
        }

        private int _vito_hp;
        public int hp_vito
        {
            get { return _vito_hp; }
            set
            {
                _vito_hp = value;
                OnPropertyChanged("hp_vito");
            }
        }
        public FightPage(Player attacker, Player attacked)
        {
            InitializeComponent();
            //player1 = Player.player1;
            name_enemy = attacked.Name;
            hp_enemy = attacked.HP;
            hp_vito = attacker.HP;
            DataContext = this;
            
        }
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
