using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241010
{
    internal class 演習問題1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("一番目の数字を入力してください。");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("二番目の数字を入力してください。");
                int num2 = int.Parse(Console.ReadLine());

                //足し算
                int addResult = Add(num1, num2);
                //引き算
                int subResult = Sub(num1, num2);
                //掛け算
                int mulResult = Mul(num1, num2);
                //割り算
                int divResult = Div(num1, num2);

                Console.WriteLine($"{num1} + {num2} = {addResult}");
                Console.WriteLine($"{num1} - {num2} = {subResult}");
                Console.WriteLine($"{num1} * {num2} = {mulResult}");
                Console.WriteLine($"{num1} ÷ {num2} = {divResult}");
                Console.WriteLine("計算を終了します");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("エラー：0でわることはできません");
                Console.WriteLine($"詳細:{ex.Message}");
                Console.WriteLine("計算を終了します");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("入力が無効です。整数を入力してください。");
                Console.WriteLine($"詳細:{ex.Message}");
                Console.WriteLine("計算を終了します");
            }
        }
        /// <summary>
        /// 足し算
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// 引き算
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// 掛け算
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Div(int num1, int num2)
        {
            if(num2 == 0)
            {
                throw new DivideByZeroException("0で割ろうとしています。");
            }
            return num1 / num2;
        }
    }
}
