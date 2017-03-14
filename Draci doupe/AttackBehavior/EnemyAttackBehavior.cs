using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.AttackBehavior
{
    class EnemyAttackBehavior : IAttackBehavior
    {
        public void Attack(Player p, int attackStrenght)
        {
            p.HP -= attackStrenght;
            

            //dorseit pocitani se statama a napojeni na random od cube

            //defense - násobení obrany -------
            //vitality - pocet zivotu musi se koeficient kterym se nasoby HP napr x 1.30
            //strenght - násobení ůtoku -------

        }
    }
}
