using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241107
{
    internal class 練習
    {
       struct Point
        {
            public double x;
            public double y;

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public void Display()
            {
                Console.WriteLine($"x座標：{x},y座標：{y}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("x座標を入力してください");
            var xPos=double.Parse(Console.ReadLine());
            Console.WriteLine("y座標を入力してください");
            var yPos=double.Parse(Console.ReadLine());
            Point point = new Point(xPos, yPos);    

            point.Display();
        }
    }
}
