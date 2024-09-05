using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20240905
{
    class Character
    {
        protected string name;
        protected int Health;
        protected int AttackPower;
        protected int chose;
        
        public virtual void Attack()
        {
            Console.WriteLine($"{this.name}の攻撃！");
        }

        public virtual void SetHealth(int tmp)
        {
           this.Health = tmp;
        }

        public virtual void SetChose(int tmp)
        {
            this.chose = tmp;
        }

        public virtual void SetAttackPower(int tmp)
        {
            this.chose = tmp;
        }

        //ゲッター
        public virtual int GetChose() { return  this.chose; }
        public virtual int GetAttackPower() { return this.AttackPower; }
        public virtual int GetHealth() {  return this.Health; }
        public virtual string GetName() { return this.name; }
    }

    class Warrior : Character
    {
        public Warrior()
        {
            name = "ウォーリアー";
            Health = 100;
        }

        public override void Attack()
        {
            Console.WriteLine($"{this.name}のHP：{this.Health}");
            Console.WriteLine("どれを攻撃しますか？\n0：ゴブリン、1：コボルト");
            this.chose = int.Parse(Console.ReadLine());
            Console.WriteLine($"{this.name}のぶん回し攻撃！");
           
            //ランダム生成
            Random random = new Random();
            this.AttackPower = random.Next(10, 51);
            Console.WriteLine($"{this.AttackPower}ダメージ！");
        }

        public override void SetHealth(int tmp)
        {
            this.Health = tmp;
        }

        public override void SetChose(int tmp)
        {
            this.chose = tmp;
        }

        public override void SetAttackPower(int tmp)
        {
            this.chose = tmp;
        }

        //ゲッター
        public override int GetChose() { return this.chose; }
        public override int GetAttackPower() { return this.AttackPower; }
        public override int GetHealth() { return this.Health; }
        public override string GetName() { return this.name; }
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
            Console.WriteLine("どれを攻撃しますか？\n0：ゴブリン、1：コボルト");
            this.chose = int.Parse(Console.ReadLine());
            Console.WriteLine($"{this.name}の魔法攻撃！");
            Random random = new Random();
            this.AttackPower = random.Next(10, 51);
            Console.WriteLine($"{this.AttackPower}ダメージ！");
        }
        public override void SetHealth(int tmp)
        {
            this.Health = tmp;
        }

        public override void SetChose(int tmp)
        {
            this.chose = tmp;
        }

        public override void SetAttackPower(int tmp)
        {
            this.chose = tmp;
        }

        //ゲッター
        public override int GetChose() { return this.chose; }
        public override int GetAttackPower() { return this.AttackPower; }
        public override int GetHealth() { return this.Health; }
        public override string GetName() { return this.name; }
    }

    class Archer : Character
    {
        public Archer()
        {
            name = "アーチャー";
            Health = 100;
        }
        public override void Attack()
        {
            Console.WriteLine($"{this.name}のHP：{this.Health}");
           
            Console.WriteLine("どれを攻撃しますか？\n0：ゴブリン、1：コボルト");
            this.chose = int.Parse(Console.ReadLine());
            Console.WriteLine($"{this.name}の無限の剣製！");
           
            //ランダム生成
            Random random = new Random();
            this.AttackPower = random.Next(10, 51);
            Console.WriteLine($"{this.AttackPower}ダメージ！");
        }
        public override void SetHealth(int tmp)
        {
            this.Health = tmp;
        }

        public override void SetChose(int tmp)
        {
            this.chose = tmp;
        }

        public override void SetAttackPower(int tmp)
        {
            this.chose = tmp;
        }

        //ゲッター
        public override int GetChose() { return this.chose; }
        public override int GetAttackPower() { return this.AttackPower; }
        public override int GetHealth() { return this.Health; }
        public override string GetName() { return this.name; }
    }

    class Goblin:Character
    { 
        public Goblin()
        {
            name = "ゴブリン";
            Health = 100;
        }
        public override void Attack()
        {
            //ランダム生成
            Random random = new Random();

            Console.WriteLine($"{this.name}のHP：{this.Health}");
           this.chose= random.Next(2, 5);
            Console.WriteLine($"{this.name}のこん棒攻撃！");
            this.AttackPower = random.Next(5, 10);
            Console.WriteLine($"{this.AttackPower}ダメージ！");
        }
        public override void SetHealth(int tmp)
        {
            this.Health = tmp;
        }

        public override void SetChose(int tmp)
        {
            this.chose = tmp;
        }

        public override void SetAttackPower(int tmp)
        {
            this.chose = tmp;
        }

        //ゲッター
        public override int GetChose() { return this.chose; }
        public override int GetAttackPower() { return this.AttackPower; }
        public override int GetHealth() { return this.Health; }
        public override string GetName() { return this.name; }
    }

    class Kobold : Character
    {
        public Kobold()
        {
            name = "コボルト";
            Health = 100;
        }
        public override void Attack()
        {
            //ランダム生成
            Random random = new Random();

            Console.WriteLine($"{this.name}のHP：{this.Health}");
            this.chose = random.Next(2, 5);
            Console.WriteLine($"{this.name}の槍攻撃！");
            this.AttackPower = random.Next(5, 10);
            Console.WriteLine($"{this.AttackPower}ダメージ！");
        }
        public override void SetHealth(int tmp)
        {
            this.Health = tmp;
        }

        public override void SetChose(int tmp)
        {
            this.chose = tmp;
        }

        public override void SetAttackPower(int tmp)
        {
            this.chose = tmp;
        }

        //ゲッター
        public override int GetChose() { return this.chose; }
        public override int GetAttackPower() { return this.AttackPower; }
        public override int GetHealth() { return this.Health; }
        public override string GetName() { return this.name; }
    }

    class System
    {
        public void Calculation(Character character,Character enemy)
        {
            int tmp = enemy.GetHealth() - character.GetAttackPower();
            enemy.SetHealth(tmp);
        }

        public void Display(Character character)
        {
            int Helth = character.GetHealth();
            string name= character.GetName();

            Console.WriteLine($"{name}残りHP{Helth}");
        }
    }


}
