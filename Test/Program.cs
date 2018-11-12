using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        /// <summary>
        /// Funkcja wybierająca losowego przeciwnika z listy
        /// </summary>
        /// <param name="firtstOnList">Numer od którego funkcja może wybrać przeciwnika</param>
        /// <param name="lastOnList">Numer do którym funkcja może wybraćprzeciwnika (Ostatni numer + 1)</param>
        /// <returns></returns>
        public static Enemy RndEnemy(int firtstOnList, int lastOnList)
        {
            Random rnd = new Random();
            int rndEnemy = rnd.Next(firtstOnList, lastOnList);
            return new Enemy(rndEnemy);
        }

        public static Enemy RndEnemySpecific(params int[] list)
        {
            Random rnd = new Random();
            int rndEnemy = rnd.Next(0, list.Count());
            return new Enemy(list[rndEnemy]);
        }

        static void Main()
        {
            while (true)
            {
                Enemy fightEnemy = RndEnemySpecific(1, 2, 6);
                Console.WriteLine("Przeciwnik: " + fightEnemy.Name + "\nHp: " + fightEnemy.Hp + "\nDamage: " + fightEnemy.Damage);
                Console.ReadKey();
            }
        }
    }
}
