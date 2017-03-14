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
        int HP { get; set; } // zavisle na Vitality_number
        //int Strenght { get; set; } // tady bude vysledne cislo po nasobeni
        int Strenght_number { get; set; }
        //int Vitality { get; set; }
        int Vitality_number { get; set; }
        //int Stamina { get; set; }
        int Defense{ get; set; }
        int Attack { get; set; } // zavisle na Strenght_number
        //void Player(string name) { }

        // strenght = 1 / 10  1 + 0,10
        //        x /= 10        x += 1  
        
        //vitality =  

    }
}
