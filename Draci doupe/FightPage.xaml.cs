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
        public IPlayer player1 { get; set; }
        private string name;
        public string namet
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("namet");
            }
        }
        public FightPage()
        {
            InitializeComponent();
            //Name = player1.Name;
            
            player1 = Player.player1;
            namet = player1.Name;
            DataContext = this;
            
        }
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
