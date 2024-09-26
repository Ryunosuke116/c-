using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20240926
{
    public class Player
    {
        protected int number;

        public int GetNumber()
        {
            return number;
        }
      
        //インスタンス化
        public Player()
        {
            number = 0;
        }
        public void choice()
        {
            while (true)
            {

                Console.WriteLine("0：ストレート　1：カーブ　2：スライダー　3：シンカーの中から選んでください");
                number = int.Parse(Console.ReadLine());

                //0以上3以下の場合次に行く
                if(number >= 0 && number <= 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("入力し直してください");
                }
            }
        }
    }

    public class CPU : Player
    {
        //インスタンス化
        public CPU()
        {
            number = 0;
        }

        public void choice()
        {
            Random random = new Random();
            number = random.Next(0,4);
        }
    }

    public class Judge
    {
        private int ballCount;
        private int strikeCount;
        private int outCount;
        private int hitCount;
        private bool isEnd;

        public bool GetIsEnd()
        {
            return isEnd;
        }

        //初期化
        public Judge()
        {
            ballCount = 0;
            strikeCount = 0;
            outCount = 0;
            hitCount = 0;
            isEnd = false;
        }
        public void judge(int playerNumber,int CpuNumber)
        {
            //数字が違う場合ストライクorボール
            if (playerNumber != CpuNumber)
            {
                Random random = new Random();
                int num = random.Next(0, 4);

                if (num >= 0 && num <= 2)
                {
                    Console.WriteLine("ストライク！！");
                    //75%の確率でストライク、25%でボール
                    strikeCount++;
                    //ストライク3つで1アウト
                    if (strikeCount >= 3)
                    {
                        Console.WriteLine("アウト！");
                        outCount++;
                        strikeCount = 0;
                    }
                }
                else
                {
                    Console.WriteLine("ボール！");
                    ballCount++;
                    //ボール４つで1ヒット
                    if (ballCount >= 4)
                    {
                        hitCount++;
                    }
                }
            //同じ数字でヒット
            }
            else if (playerNumber == CpuNumber)
            {
                Console.WriteLine("ヒット！");
                hitCount++;
            }
            
            //3アウトで試合終了、プレイヤーの勝利
            if(outCount >= 3)
            {
                Console.WriteLine("試合終了！！");
                Console.WriteLine("PLAYER WIN");
                isEnd = true;
            }
            else if(hitCount >= 4)
            {
                Console.WriteLine("試合終了！！");
                Console.WriteLine("CPU WIN");
                isEnd = true;
            }
        }
    }


    internal class Class1
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            CPU cpu = new CPU();
            Judge judge = new Judge();

            while (true)
            {
                player.choice();
                cpu.choice();
                judge.judge(player.GetNumber(),cpu.GetNumber());

                if(judge.GetIsEnd())
                {
                    break;
                }
            }    
        }

    }
}
