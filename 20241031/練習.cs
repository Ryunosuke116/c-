using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241031
{
  

    internal class 練習
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Random random = new Random();

            //リストに追加
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(1, 20));

                Console.WriteLine(numbers[i]);
            }
            //リストを削除
            numbers.Remove(20);

            //要素検索
            Console.WriteLine("検索したい数字を入力してください。");
            int num = int.Parse(Console.ReadLine());

            numbers.IndexOf(num);

            if (num != -1)
            {
                Console.WriteLine($"検索した数字は{num}");
            }
            else
            {
                Console.WriteLine("検索した数字はありません。");
            }

            //要素のフィルター（偶数）
            List<int> everNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine($"偶数:{string.Join(",", everNumbers)}");
            //リストの逆順
            numbers.Reverse();
            Console.WriteLine($"逆順：{string.Join(", ", everNumbers)}");
        }
    }
}
