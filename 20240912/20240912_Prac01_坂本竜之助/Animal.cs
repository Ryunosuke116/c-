using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20240912._20240912_Prac01_坂本竜之助
{

    public class Lion : IAnimal
        {
            public void Speak()
            {
                Console.WriteLine("がオー");
            }
        }

    public class Elephant : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("パオーン");
        }
    }
    public class Bard : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("ピー");
        }
    }

    public class Zoo
    {
        Lion lion = new Lion();
        Elephant elephant = new Elephant();
        Bard bard = new Bard();

        public void MakeAllAnimalsSpeak()
        {
            lion.Speak();
            elephant.Speak();
            bard.Speak();
        }
    }

}
