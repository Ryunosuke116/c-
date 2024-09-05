using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace c_._20240905
{

    class Character
    {
        protected string name;
        protected int Health;

        public virtual void Attack()
        {
            Console.WriteLine($"{this.name}の攻撃！");
        }
    }

    class Warrior:Character
    {
        public Warrior()
        {
            name = "ウォーリアー";
            Health = 100;
        }

        public override void Attack()
        {
            Console.WriteLine($"{this.name}のHP：{this.Health}");
            Console.WriteLine($"{this.name}のぶん回し攻撃！");
        }
    }

    class Mage : Character
    {
        public Mage()
        {
            name = "メイジ";
            Health = 100;
        }
        public override void Attack()
        {
            Console.WriteLine($"{this.name}のHP：{this.Health}");
            Console.WriteLine($"{this.name}の魔法攻撃！");
        }
    }

    class Archer:Character
    {
        public Archer()
        {
            name = "アーチャー";
            Health = 100;
        }
        public override void Attack()
        {
            Console.WriteLine($"{this.name}のHP：{this.Health}");
            Console.WriteLine($"{this.name}の無限の剣製！");
        }
    }

    internal class _20240905_Prac02_坂本竜之助
    {
        static void Main( string[] args )
        {
            //インスタンス化
            Character[] characters = new Character[3];

            //派生クラスのインスタンス化
            characters[0] = new Warrior();
            characters[1] = new Mage();
            characters[2] = new Archer();

            foreach(var character  in characters)
            {
                character.Attack();
            }

        }
    }
}
