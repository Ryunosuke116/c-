using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace c_
{

    public class Player
    {
        public int level;
        private int score;

        public Player() 
        {
            score = 0;
            level = 1;
        }
        public void AddScore(int points)
        {
            //scoreにポイントを加算
            score += points;
            Console.WriteLine($"現在の経験値{score}");

            //レベルアップに必要なスコアを定義
            int conditionsNumber = 10;

            //100以上の場合レベルアップかつ必要なスコアを増加
            while(true)
            {
                if (points >= conditionsNumber)
                {
                    level++;
                    conditionsNumber += 10;
                    LevelUp();
                }
                else
                {
                    break;
                }
            }
        }

        public void LevelUp()
        {
            Console.WriteLine($"レベルアップ！\n現在のレベル{this.level}");
        }

        public void ResultDisplay()
        {
            Console.WriteLine("結果発表!!");
            Console.WriteLine($"レベル{this.level}");
        }
    }

    public class Judgement
    {
        public int points;

        public Judgement()
        {
            points = 100;
        }
        public void Problem()
        {
            //ランダムな数字を生成
            Random r = new Random();
            int random = r.Next(1, 101);

            Console.WriteLine("1～100までのランダムな数字を当ててください、全部で5問です");

            points = 100;

            while (true)
            {
                int tmp;
                tmp = int.Parse(Console.ReadLine());

                if(tmp > 0 && tmp <= 100)
                {
                    if(tmp > random)
                    {
                        Console.WriteLine("Big");

                        //間違えるたびにポイントを減らす
                        points -= 10;

                        //0以下にならないようにする
                        if (points < 0)
                        {
                            points = 0;
                        }
                    }
                    else if (tmp < random)
                    {
                        Console.WriteLine("Small");
                        //間違えるたびにポイントを減らす
                        points -= 10;

                        //0以下にならないようにする
                        if (points < 0)
                        {
                            points = 0;
                        }
                    }
                    else if(tmp == random)
                    {
                        Console.WriteLine("正解！");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("書き直してください。");
                }
            }
        }
    }


    internal class Class1
    {
        static void Main()
        {
            //インスタンス化
            Player player = new Player();
            Judgement judgement = new Judgement();

            for(int i = 0; i < 5; i++)
            {
                judgement.Problem();
                player.AddScore(judgement.points);
            }
            player.ResultDisplay();
        }
    }
}
