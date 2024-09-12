
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20240912._20240912_Prac01_坂本竜之助
{
    public interface IAnimal
    {
        void Speak();
    }
    internal class main
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            Elephant elephant = new Elephant();
            Bard bard = new Bard();
            Zoo zoo = new Zoo();

            lion.Speak();
            elephant.Speak();
            bard.Speak();
            zoo.MakeAllAnimalsSpeak();

        }

    }
}
