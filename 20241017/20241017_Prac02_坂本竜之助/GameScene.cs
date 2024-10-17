using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241017._20241017_Prac02_坂本竜之助
{

    public class GameScene
    {
        public void PlayGame()
        {
            //入力できる上限
            const int max = 2;
            const int min = 0;
            int playerChoice = -1;
            int enemyChoice = -1;

            Console.WriteLine("0：グー、1：チョキ、2：パーから選んでね");
            while (true)
            {
                
                playerChoice = int.Parse(Console.ReadLine());
               
                //入力チェック
                if(playerChoice >= min && playerChoice <= max)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("入力しなおしてください。");
                }
            }
            //敵の選択
            Random random = new Random();
            enemyChoice = random.Next(min, max + 1);
            //ジャッジ
            Judge(playerChoice, enemyChoice);
        }

       public void Judge(int player,int enemy)
        {
            //ポイント
            const int winPoint = 15;
            const int drawPoint = 5;
            const int losePoint = 1;

            int judge = player - enemy;

            //勝ち
            if(judge == -1 || judge == 2 )
            {
                Console.WriteLine("PLAYERの勝ち！+15点！");
                ScoreManager.AddScore(winPoint);
            }
            //引き分け
            else if(judge == 0)
            {
                Console.WriteLine("あいこ！+5点！");
                ScoreManager.AddScore(drawPoint);
            }
            //負け
            else
            {
                Console.WriteLine("お前の負けぇぇぇぇぇぇ！+1点");
                ScoreManager.AddScore(losePoint);
            }
        }
    }
}
