using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20240912
{
    public class Character
    {
        public string Name { get; set; }
        public int HP {  get; set; }
        public int AttackPower {  get; set; }
    }

    public class Player:Character,IAttackbale
    {
        Random random = new Random();
        public Player(string name)
        {
            Name = name;
            HP = random.Next(10, 99);
            AttackPower = random.Next(2, 15);
        }
        public void Attack(string name)
        {
            Console.WriteLine($"{name}に攻撃する");
        }
    }
    public class Enemy : Character, IAttackbale
    {
        Random random = new Random();

        public Enemy(string name)
        {
            Name = name;
            HP = 0;
            AttackPower = 0;
        }
        public void Attack(string name)
        {
            Console.WriteLine($"{name}に攻撃する");
        }
    }

   
}
