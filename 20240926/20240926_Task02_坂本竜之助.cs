using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c_._20240926
{
    public class Player
    {
        protected int number;
        protected int isDraw;

        public Player() 
        {
            number = 0;
            isDraw = 0;
        }

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public int IsDraw
        {
            get { return this.isDraw; }
            set { this.isDraw = value; }
        }
        
        //カードを引く
        public void CardDraw()
        {
            Random random = new Random();
            Number += random.Next(1, 12);
        }

        public void isCardDraw()
        {
            Console.WriteLine("カードを引きますか？");
            Console.WriteLine("Yes:0 No:1");
            while (true)
            {
                isDraw = int.Parse(Console.ReadLine());
                if (isDraw >= 0 && isDraw <= 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("書き直してください");
                }
            }
        }
    }

    public class Enemy:Player
    {
        public Enemy()
        {
            number = 0;
            isDraw = 0;
        }
    }

    public class Judge
    {
        private Player player;
        private Enemy enemy;
        public Judge()
        {
           this.player = new Player();
           this.enemy = new Enemy();
        }

        public void DrawCard()
        {
            Random random = new Random();

            //カードを二回引く
            for (int i = 0; i < 2; i++)
            {
                player.Number = random.Next(1, 12);
                enemy.Number = random.Next(1, 12);
            }
            Display();
        }
        
        public void Display()
        {
            Console.WriteLine($"プレイヤー:{player.Number}\n相手:{enemy.Number}");
        }
        public void judge()
        {
            //初期カードを引く
            DrawCard();

            while (true)
            {
                //カードを引くか決める
                player.isCardDraw();

                if (player.IsDraw == 0)
                {
                    player.CardDraw();
                }
                //ジャッジ
                if(player.Number == 21)
                {
                    Display();
                    Console.WriteLine("プレイヤーの勝ち");
                    break;
                }
                else if(player.Number >= 22)
                {
                    Display();
                    Console.WriteLine("プレイヤーの負け");
                    break;
                }
                //プレイヤーよりカードの数字が小さい場合カードを引く
                if(player.Number >= enemy.Number)
                {
                    enemy.CardDraw();
                }
                //ジャッジ
                if (enemy.Number == 21)
                {
                    Display();
                    Console.WriteLine("プレイヤーの負け");
                    break;
                }
                else if (enemy.Number >= 22)
                {
                    Display();
                    Console.WriteLine("プレイヤーの勝ち");
                    break;
                }
                //現在のカードを表示
                Display();
            }
        }
    }


    internal class _20240926_Task02_坂本竜之助
    {
        static void Main(string[] args)
        {
            Judge judge = new Judge();
            judge.judge();
        }
    }
}
