using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.AttackBehavior
{
    class EnemyAttackBehavior : IAttackBehavior
    {
        public void Attack(Player player_atacker, Player player_attacked, int attackStrenght)
        {
            //p.HP -= attackStrenght;

            double nasobitel_utoku = player_atacker.Strenght / 10 + 1;

            double delitel_utoku = 1 - player_attacked.Strenght / 10;

            double utok_hodnota = player_atacker.Attack * nasobitel_utoku * delitel_utoku;

            player_attacked.HP -= (int)Math.Round(utok_hodnota, 0);


            // strenght = 1 / 10  1 + 0,10
            //        x /= 10        x += 1


            //dorseit pocitani se statama a napojeni na random od cube

            //defense - násobení obrany -------
            //vitality - pocet zivotu musi se koeficient kterym se nasoby HP napr x 1.30
            //strenght - násobení ůtoku -------

        }
    }
}
