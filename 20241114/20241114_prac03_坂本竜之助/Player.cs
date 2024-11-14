using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241114._20241114_prac03_坂本竜之助
{
    public class Player:IMovable
    {
        public int x{  get; private set; }
        public int y{ get; private set; }

        public void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public override string ToString()
        {
            return "playerの座標：(" + x + "," + y + ")";
        }
    }
}
