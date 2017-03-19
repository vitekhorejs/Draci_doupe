using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    class Mission
    {
        public string Mission_name { get; set; }
        public bool Done { get; set; }
        public string Mission_text { get; set; }
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
