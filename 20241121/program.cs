using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241121
{
    internal class program
    {
        static void Main(string[] args)
        {
            //LINQがないとき
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            //LINQがある場合
            var Number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNum = Number.Where(n => n % 2 == 0);

            var orderNum = Number.OrderByDescending(num => num).ToList();

            foreach (int number in evenNum)
            {
                Console.WriteLine(number);
            }

            foreach (int number in orderNum)
            {
                Console.WriteLine($"{number}");
            }
        }
    }
}
