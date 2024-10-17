using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241017
{
    internal class 練習問題
    {
        
        public static int calcu(int num1,int num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            var number1=int.Parse(Console.ReadLine());
            var number2=int.Parse(Console.ReadLine());
            int sum = calcu(number1, number2);
            Console.WriteLine($"{number1} + {number2} = {sum}");
        }

    }
}
