using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.AttackBehavior
{
    interface IAttackBehavior
    {
        void Attack(Player player_attacker, Player attacked, int attackStrenght);
    }
}
