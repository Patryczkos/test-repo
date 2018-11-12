using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class EnemyList
    {
        public List<Enemy> DefaultEnemyList = new List<Enemy>();

        public EnemyList()
        {
            DefaultEnemyList.Add(new Enemy(1, "Rat", 20, 5));
            DefaultEnemyList.Add(new Enemy(2, "Mutated Rat", 30, 6));
            DefaultEnemyList.Add(new Enemy(3, "Orc", 50, 10));
            DefaultEnemyList.Add(new Enemy(4, "Orc Warrior", 80, 12));
            DefaultEnemyList.Add(new Enemy(5, "Orc Leader", 150, 15));
            DefaultEnemyList.Add(new Enemy(6, "Snake", 25, 5));
        }
    }
}
