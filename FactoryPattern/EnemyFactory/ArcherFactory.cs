using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class ArcherFactory : EnemyFactory
    {
        public override Enemy CreateEnemy()
        {
            return new Archer();
        }
    }
}
