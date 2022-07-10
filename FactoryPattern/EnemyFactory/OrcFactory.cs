using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class OrcFactory : EnemyFactory
    {
        public override Enemy CreateEnemy()
        {
            return new Orc();
        }

    }
}
