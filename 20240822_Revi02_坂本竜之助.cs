using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_
{
    public class Player
    {
        protected int cardNumber;
       
        public Player() 
        {
            cardNumber = 0;
        }
        public void Distribution()
        {
            for (int i = 0; i < 2; i++)
            {
                cardNumber += RandomNumber(1, 12);
            }
        }
        /// <summary>
        /// カードのセットアップ
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        /// <summary>
        /// カードを引く
        /// </summary>
        public void  DrawCard()
        {
            Console.WriteLine("カードを引きますか？");

            int choice;

            while(true)
            {
                choice=int.Parse(Console.ReadLine());

                if(choice >= 0 && choice <= 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("書き直してください。");
                }
            }

            if(choice == 0)
            {
                cardNumber += RandomNumber(1, 12);
            }
        }
        /// <summary>
        /// カードの大きさを取得
        /// </summary>
        /// <returns></returns>
        public int GetCardNumber()
        {
            return this.cardNumber;
        }


        public bool isCardNumber()
        {
            if(cardNumber >= 21)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }

    public class Enemy : Player
    {
        public Enemy()
        {
            this.cardNumber = 0;
        }
        public void DrawCard(Player player)
        {
            //プレイヤーのカードの方が大きい場合にEnemyはカードを引く
            if (this.cardNumber <= player.GetCardNumber())
            {
                this.cardNumber += RandomNumber(1, 12);
            }
        }
    }

    public class Common
    {

        public void SetUp(Player player, Enemy enemy)
        {
            //お互いカードを引く
            player.Distribution();
            enemy.Distribution();
            DisplayCardNumber(player, enemy);
        }
        public void Judgement(Player player, Enemy enemy)
        {

            //カードを引くか選ぶ
            player.DrawCard();
            enemy.DrawCard(player);
            DisplayCardNumber(player, enemy);

        }

        public void Result(Player player, Enemy enemy)
        {
            if (player.GetCardNumber() > 21 && enemy.GetCardNumber() > 21)
            {
                Console.WriteLine("引け分け！");
            }
            else if (player.GetCardNumber() == 21 || enemy.GetCardNumber() >= 21)
            {
                Console.WriteLine("プレイヤーの勝ち！");
            }
            else if (enemy.GetCardNumber() == 21 || player.GetCardNumber() >= 21)
            {
                Console.WriteLine("プレイヤーの負け！");
            }

        }

        /// <summary>
        /// カードの大きさの表示
        /// </summary>
        /// <param name="player"></param>
        /// <param name="enemy"></param>
        public void DisplayCardNumber(Player player, Enemy enemy)
        {
            Console.WriteLine($"現在のカードの大きさ");
            Console.WriteLine($"プレイヤー:{player.GetCardNumber()}　相手:{enemy.GetCardNumber()}");
        }
    }


    internal class _20240822_Revi02_坂本竜之助
    {
        static void Main()
        {
            //インスタンス化
            Player player = new Player();
            Enemy enemy = new Enemy();
            Common common = new Common();
            
            common.SetUp(player, enemy);
            
            while (true)
            {
                common.Judgement(player, enemy);
                if(player.isCardNumber() || enemy.isCardNumber())
                {
                    break;
                }
            }
            common.Result(player, enemy);
        }
    }
}
