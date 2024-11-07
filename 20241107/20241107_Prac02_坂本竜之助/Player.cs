using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace c_._20241107._20241107_Prac02_坂本竜之助
{
        public struct Player_
        {
            private string name;    //名前
            private int HP;         //HP
            private int attack;     //攻撃力

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Attack
            {
                get { return attack; }
                set { attack = value; }
            }

            public int HP_
            {   get { return HP; }
                set { HP = value; } 
            }

            public Player_()
            {
                //何もない
            }

            /// <summary>
            /// 初期化
            /// </summary>
            public void Initialize()
            {
                Random random = new Random();
                HP = random.Next(15, 55);
                Attack = random.Next(15, 55);
            }

            /// <summary>
            /// ダメージ計算
            /// </summary>
            /// <param name="damage"></param>
            public void TakeDamage(int damage)
            {
                HP -= damage;
                if (HP < 0) HP = 0;
            }

            /// <summary>
            /// 描画
            /// </summary>
            public void Display()
            {
                Console.WriteLine($"名前：{name}");
                Console.WriteLine($"HP：{HP}");
                Console.WriteLine($"攻撃力：{Attack}");
            }

        }
    internal class Player
    {
    }
}
