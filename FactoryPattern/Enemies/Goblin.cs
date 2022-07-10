using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Goblin : Enemy
    {
        public override string EnemyType { 
            get 
            {
                return "Goblin";
            } 
        }
    }
}
