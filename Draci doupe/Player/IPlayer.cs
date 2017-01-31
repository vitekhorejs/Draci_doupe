using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Level { get; set; }
        int HP { get; set; }
        int Strenght { get; set; }
        int Vitality { get; set; }
        int Stamina { get; set; }
        int Defense{ get; set; }
        //void Player(string name) { }
    }
}
