using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    ///<summary>
    /// Klasa Przeciwnika
    ///</summary>
    class Enemy
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Damage { get; set; }

        public Enemy(int id)
        {
            EnemyList EnemyList = new EnemyList();

            Id = id;

            Enemy enemy = EnemyList.DefaultEnemyList.Find(x => x.Id == id);

            Name = enemy.Name;
            Hp = enemy.Hp;
            Damage = enemy.Damage;
        }

        public Enemy(string name)
        {
            EnemyList EnemyList = new EnemyList();

            Name = name;

            Enemy enemy = EnemyList.DefaultEnemyList.Find(x => x.Name == name);

            Id = enemy.Id;
            Hp = enemy.Hp;
            Damage = enemy.Damage;       
        }

        public Enemy(int id, string name, int hp, int damage)
        {
            Id = id;
            Name = name;
            Hp = hp;
            Damage = damage;
        }
    }
}
