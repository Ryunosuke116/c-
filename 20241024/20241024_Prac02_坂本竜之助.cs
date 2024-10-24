using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241024
{
    internal class _20241024_Prac02_坂本竜之助
    {
        static void Main(string[] args)
        {
            //マップ
            List<int> map = new List<int>() { 1,0,0,0,0,0,0,0,0,0};
            int choice;                 //選択
            const int maxTurn = 5;      //最大ターン数
            const int maxChoice = 10;   //最大値
            const int minChoice = 1;    //最小値

            //シャッフル
            map = map.OrderBy(a => Guid.NewGuid()).ToList();
            
            Console.WriteLine("1から10までのエリアに一つだけ宝が隠されています。");
            Console.WriteLine("宝を5ターン以内に見つけてくだちい。");

            for (int i = 0; i < maxTurn; i++)
            {
                Console.WriteLine($"{i + 1}ターン目");
                Console.WriteLine("1から10の探したいエリアを選んでくだちい。");
                //チェック
                while(true)
                {
                    choice = int.Parse(Console.ReadLine());
                    if(choice >= minChoice && choice <= maxChoice)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("1から10の中から選んでくだちい。");
                    }
                }

                if (map[choice - 1] == 1)
                {
                    Console.WriteLine("お宝発見！ゲームクリア！");
                    break;
                }
                else
                {
                    Console.WriteLine("何も…な゛かった…!!!");
                }
                if (map[choice - 1] == 0 && i == 4)
                {
                    Console.WriteLine("ゲームオーバー");

                }
                
            }
        }
    }
}
