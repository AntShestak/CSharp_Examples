using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    abstract class EnemyFactory
    {
        public abstract Enemy CreateEnemy();
    }
}
