using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241017
{
    public class Calculator
    {
        /// <summary>
        /// 足し算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
         public static int Add(int a,int b)
         {
            return a + b;
         }

        /// <summary>
        /// 掛け算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Multiply(int a,int b)
        {
            return a * b;
        }

        /// <summary>
        /// 奇数か偶数か
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string IsEven(int num)
        {
            if(num % 2 == 0)
            {
                return "偶数です";
            }
            return "奇数です";
        }

        /// <summary>
        /// どちらが大きいか
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

    }

    internal class _20241017_Prac01_坂本竜之助
    {
        static void Main(string[] args)
        {
            Console.WriteLine("一つ目の数字を入力してください。");
            var number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("二つ目の数字を入力してください。");
            var number2 = int.Parse(Console.ReadLine());

            //足し算
            Console.WriteLine($"{number1} + {number2} = {Calculator.Add(number1, number2)}");
            //掛け算
            Console.WriteLine($"{number1} * {number2} = {Calculator.Multiply(number1, number2)}");
            //偶数か奇数か
            Console.WriteLine($"{number1}は{Calculator.IsEven(number1)}");
            Console.WriteLine($"{number2}は{Calculator.IsEven(number2)}");
            //大きい数
            Console.WriteLine($"{Calculator.Max(number1,number2)}の方が大きいです。");
        }

    }
}
