using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class GoblinFactory : EnemyFactory
    {
        public override Enemy CreateEnemy()
        {
            return new Goblin();
        }
    }
}
