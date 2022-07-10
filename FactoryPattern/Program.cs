using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyFactory[] enemyFactories = new EnemyFactory[3];

            enemyFactories[0] = new GoblinFactory();
            enemyFactories[1] = new ArcherFactory();
            enemyFactories[2] = new OrcFactory();

            foreach (var factory in enemyFactories)
            {
                Enemy enemy = factory.CreateEnemy();
                Console.WriteLine($"Created {enemy.EnemyType}");
            }

        }
    }
}
