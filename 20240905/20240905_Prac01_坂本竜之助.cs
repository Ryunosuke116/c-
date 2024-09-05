using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_
{

    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("食べた");
        }
    }

    class Lion : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("肉を食べた");
        }
    }

    class Elephant : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("草を食べた");
        }
    }



    internal class _20240905_Prac01_坂本竜之助
    {

        static void Main(string[] args)
        {
            //インスタンス化
            Animal[] animals = new Animal[2]; 

            //派生クラスのインスタンス化
            animals[0] = new Lion();
            animals[1] = new Elephant();

            foreach (var a in animals)
            {
                a.Eat();
            }
        }

    }
}
