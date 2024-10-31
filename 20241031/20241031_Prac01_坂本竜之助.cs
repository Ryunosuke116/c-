using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241031
{

    internal class _20241031_Prac01_坂本竜之助
    {
        static T FindMin<T>(List<T> items,Func<T,bool> predicate) where T : IComparable<T>
        {
            T minItem = default(T);
            bool found = false;

            foreach (T item in items)
            {
                if(predicate(item) && (!found || item.CompareTo(minItem) < 0))
                {
                    minItem = item;
                    found = true;   
                }
                
            }

            return minItem;
        }

        static void Main(string[] args)
        {
            List<int> items = new List<int>();
            Random random = new Random();
            //10個生成
            for (int i = 0; i < 10; i++)
            {
                items.Add(random.Next(0, 50));
                Console.WriteLine($"{items[i]}");
            }

            //最小値を抽出
            int minItem = FindMin(items, n => n % 2 == 0);
            //最小値を表示
            Console.WriteLine($"最小値は、{minItem}");
        }
    }
}
