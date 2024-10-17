using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241017._20241017_Prac02_坂本竜之助
{
    public class ResultScene
    {
        int threshold = 100;        //閾値
        const int max = 2;          //上限値   
        const int min = 1;          //下限値

        /// <summary>
        /// 結果発表！！
        /// </summary>
        public void Result()
        {
            Console.WriteLine($"最終スコア：{ScoreManager.CurrentScore()}");
            if(ScoreManager.IsHighScore(threshold))
            {
                Console.WriteLine("ハイスコア更新！");
                threshold = ScoreManager.CurrentScore();
            }

            Console.WriteLine("もう一回やる？");
            Console.WriteLine("1：はい、2：いいえ");

            //入力チェック
            while (true)
            {

               ScoreManager.RestartOrEnd = int.Parse(Console.ReadLine());
                if(ScoreManager.RestartOrEnd >= min &&
                    ScoreManager.RestartOrEnd <= max)
                {
                    
                    break;
                }
                else
                {
                    Console.WriteLine("入力しなおしてください。");
                }
            }

        }

    }
}
