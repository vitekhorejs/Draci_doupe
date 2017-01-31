using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    class Player : IPlayer
    {
        private int hp;
        private string name;
        private int level;
        private int stamina;
        private int vitality;
        private int defense;
        private int strenght;

        public Player(string name)
        {
            this.name = name;
        }

        /*void IPlayer.Player(string name)
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
            get { return hp; }
            set { hp = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public int Stamina
        {
            get { return stamina; }
            set { stamina = value; }
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

    }
}
