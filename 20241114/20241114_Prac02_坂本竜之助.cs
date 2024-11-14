using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241114
{
    internal class _20241114_Prac02_坂本竜之助
    {
        public interface IMovable
        {
            void Move(int x, int y);

        }
        public struct Point : IMovable
        {
            public int x { get; private set; }
            public int y { get; private set; }
            public void Move(int x, int y)
            {
                this.x += x;
                this.y += y;
            }

        }
        static void Main(string[] args)
        {
            Point point = new Point();

            point.Move(5, 5);
            Console.WriteLine($"Position:({point.x},{point.y})");
        
        }

    }

    
}
