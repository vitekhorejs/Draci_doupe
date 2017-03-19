using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    public class Mission
    {
        Mission_adding missions = new Mission_adding();
        /*public Mission(int n)
        {
            _id_mission = n;
            /*_name_mission = missions.GetMissionName(n);
            _text_mission = missions.GetMissionText(n);*/
            /*_name_mission = Name_Mission;
            _text_mission = Text_Mission;

        }*/


        private int _id_mission;
        public int ID_Mission
        {
            get { return _id_mission; }
            set { _id_mission = value; }
        }

        private string _name_mission;
        public string Name_Mission
        {
            get { return _name_mission; }
            set { _name_mission = value; }
        }

        private string _text_mission;
        public string Text_Mission
        {
            get { return _text_mission; }
            set { _text_mission = value; }
        }

        public bool Done { get; set; }
        public string Mission_description { get; set; }
        public int Level { get; set; }
        public string Enemy_name { get; set; }
        public int Enemy_Strenght { get; set; }
        public int Enemy_HP { get; set; }
        public int Enemy_Attack { get; set; }
        public int Enemy_defense { get; set; }
        public int Reward { get; set; }
    }
}
