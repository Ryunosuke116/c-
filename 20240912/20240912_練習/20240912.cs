using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20240912
{
    public interface IAttackbale
    {
        void Attack(string name);
    }
    internal class _20240912
    {
        static void Main(string[] args)
        {
            Console.WriteLine("プレイヤーの名前を入力してください。");
            var plyName=Console.ReadLine();
            Player player = new Player(plyName);
            Console.WriteLine("敵の名前を入力してください。");
            var emyName = Console.ReadLine();
            Enemy enemy=new Enemy(emyName);

            player.Attack(emyName);
            enemy.Attack(plyName);
        }
    }
}
