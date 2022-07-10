using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Orc : Enemy
    {
        public override string EnemyType
        {
            get
            {
                return "Orc";
            }
        }
    }
}
