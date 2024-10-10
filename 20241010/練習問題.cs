using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241010
{
    internal class 練習問題
    {
        static void Main(string[] args)
        {
            //割り算をしたときの例外処理
            try
            {
                Console.WriteLine("割られる数字を入力してください。");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("割る数字を入力してください。");
                int num2 = int.Parse(Console.ReadLine());

                int result = Divide(num1, num2);
                Console.WriteLine($"{num1} ÷ {num2} = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("エラー:0で割ろうとしています。");
                Console.WriteLine($"詳細:{ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("エラー:数字が正しく入力されていません。");
                Console.WriteLine($"詳細：{ex.Message}");
            }
            finally
            {
                Console.WriteLine("プログラムを終了します");
            }

        }

        static int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("0で割ろうとしています。");
            }
            return num1 / num2;
        }
    }

          
}
