using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241031
{
    internal class _20241031_Prac02_坂本竜之助
    {
        static void Main(string[] args)
        {
           Player player = new Player();
            Inventory<string> inventory = new Inventory<string>();

            inventory.display();
            inventory.AddItem("ポーション");
            inventory.display();

            player.UseItem("ポーション");
            inventory.RemoveItem("ポーション");
            inventory.display();
        }

        public class Player
        {

            private int HP;
            /// <summary>
            /// インスタンス化
            /// </summary>
           public Player()
            {
                HP = 100;
            }

               
            public void UseItem<T>(T item)
            {
                Console.WriteLine($"{item}を使用した！");
                Console.WriteLine("10回復");
                HP += 10;
            }

        }

        public class Inventory<T>
        {
            List<string> itemBox = new List<string>();

            //  アイテム追加
            public void AddItem(T item)
            {
                Console.WriteLine("追加しますか？");
                Console.WriteLine("1：はい、2：いいえ");

                int Choice = int.Parse(Console.ReadLine());

                if(Choice == 1)
                {
                    //10個以下の場合追加する
                    if (itemBox.Count < 10)
                    {
                        itemBox.Add($"{item}");
                        Console.WriteLine($"{item}を追加しました。");
                    }
                    else
                    {
                        Console.WriteLine("アイテムがいっぱいです。");
                    }
                }
                
            }
            /// <summary>
            /// 削除
            /// </summary>
            /// <param name="item"></param>
            public void RemoveItem(T item)
            {
                itemBox.Remove($"{item}");
            }
            /// <summary>
            /// 表示
            /// </summary>
            public void display()
            {
                int num = 0;

                if(itemBox.Count == 0)
                {
                    Console.WriteLine("アイテムなし");
                }
                else
                {
                    foreach(var item in itemBox)
                    {
                        num++;
                        Console.WriteLine($"{num}:{item}");
                    }
                }
            }
        }

    }
}
