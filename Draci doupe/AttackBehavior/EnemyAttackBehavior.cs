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
            //p.HP -= attackStrenght;

            int nasobitel_utoku = p.Strenght / 10 + 1;

            int delitel_utoku = 1 - p.Strenght / 10;

            int utok_hodnota = p.Attack * nasobitel_utoku * delitel_utoku;

            p.HP -= utok_hodnota;


            // strenght = 1 / 10  1 + 0,10
            //        x /= 10        x += 1


            //dorseit pocitani se statama a napojeni na random od cube

            //defense - násobení obrany -------
            //vitality - pocet zivotu musi se koeficient kterym se nasoby HP napr x 1.30
            //strenght - násobení ůtoku -------

        }
    }
}
