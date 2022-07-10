using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Archer : Enemy
    {
        public override string EnemyType
        {
            get
            {
                return "Archer";
            }
        }
    }
}
