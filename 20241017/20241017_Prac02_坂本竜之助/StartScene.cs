using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241017._20241017_Prac02_坂本竜之助
{
    public class StartScene
    {
        public void StandBy()
        {
            //ゲーム説明
            Console.WriteLine("じゃんけんゲーム！！\nゲームは5回戦！各回の結果に応じてスコアが加算されるよ！");
            Console.WriteLine("頑張ってスコアを伸ばそう！");
            Console.WriteLine("Enterキーを押すとゲームスタート！");

           while (true)
            {
                //キーが押されているか
                if(Console.KeyAvailable)
                {
                    //ReadKeyでどのキーが押されているかを判別
                    var key = Console.ReadKey(intercept: true).Key;
                    if(key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
        }
    }
}
