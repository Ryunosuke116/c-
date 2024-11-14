using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241114
{
    internal class 練習
    {
        public record Person(string FirstName,string LastName);

        static void Main(string[] args)
        {
            var person = new Person("Masayuki", "Imai");
            var person2 = new Person("Masayuki", "imai");
            Console.WriteLine(person == person2);
            Console.WriteLine(person.FirstName);
        }
    }
}
