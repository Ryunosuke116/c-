using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_
{
    class Kart
    {
        public int weight;      //重量
        public int speed;       //速さ

        //アクセルを踏むメソッド
        public void Force()
        {
            Console.WriteLine("加速or減速");
        }

        //クラクションを鳴らす
        public virtual void Horn()
        {
            Console.WriteLine("ブッブー");
        }
    }

    class SkyKart : Kart
    {
        //離陸をするメソッド
        public void Flying()
        {
            Console.WriteLine("離陸or着陸");
        }

        //Hornメソッドをオーバーライド
        public override void Horn()
        {
            Console.WriteLine("ビビッー");
        }
    }

    class TurboKart : Kart
    {
        public void Trubo()
        {
            Console.WriteLine("ブースト！");
        }
        public override void Horn()
        {
            Console.WriteLine("ビッビー");
        }
    }

    internal class _20240905_1
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //Kart kart = new Kart();
                //SkyKart skyKart = new SkyKart();

                //kart.Force();
                //skyKart.Flying();

                ////オーバーライドしたメソッドをそれぞれ呼び出す
                //kart.Horn();
                //skyKart.Horn();

                Kart[] karts = new Kart[2];

                //派生クラスのインスタンスを生成
                karts[0] = new SkyKart();
                karts[1] = new TurboKart();

                //クラクションメソッドを鳴らします
                foreach (var kart in karts)
                {
                    kart.Horn();
                }
            }

        }
    }
}
