using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241114._20241114_prac03_坂本竜之助
{
    internal class Game
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Item item = new Item();
            List<IMovable> movables = new System.Collections.Generic.List<IMovable>();

            movables.Add(player);
            movables.Add(item);

            foreach(IMovable movable in movables)
            {
                movable.Move(5,6);
                Console.WriteLine(movable.ToString());
            }
        }
    }
}
