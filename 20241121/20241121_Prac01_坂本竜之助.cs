using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_._20241121
{
    internal class _20241121_Prac01_坂本竜之助
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(1,51));
            }
            var orderNum = numbers.OrderByDescending(num => num).ToList();
            var evenNumbers = orderNum.Where(n => n % 2 == 0);

            foreach (int number in orderNum)
            {
                Console.WriteLine($"{number}");
            }
            Console.WriteLine("偶数リスト");
            foreach(int number in evenNumbers)
            {
                Console.WriteLine($"{number}");
            }

        }
    }
}
