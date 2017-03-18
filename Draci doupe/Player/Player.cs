using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    public class Player
    {
        //public static IPlayer player1 { get; set; }
        private int hp;
        private string name;
        private int level;
        private int vitality;
        private int defense;
        private int strenght;
        private int attack;

        /*public Player(string name)
        {
            this.name = name;
        }*/

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int HP
        {
            get { return hp * vitality; }
            set { hp = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public int Vitality
        {
            get { return vitality; }
            set { vitality = value; }
        }
        public int Strenght
        {
            get { return strenght; }
            set { strenght = value; }
        }
        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
    }
}
