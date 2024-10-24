using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241024
{
    internal class _20241024_Prac01_坂本竜之助
    {
        static void Main(string[] args)
        {
            //リスト生成
            List<int> numbers = new List<int>();
            int userInput;
            //ユーザー入力
            while (true)
            {
                userInput = int.Parse(Console.ReadLine());
                if (userInput == 0)
                {
                    Console.WriteLine("0が入力されました。");
                    break;
                }
                else
                {
                    numbers.Add(userInput);
                }
            }
            Console.WriteLine("登録された数字は以下の通りです。");
            //リスト内の要素の合計計算
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"合計は{sum}です。");
            //リスト内の要素を昇順にソート
            numbers.Sort();
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
