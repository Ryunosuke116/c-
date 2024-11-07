using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241107._20241107_Prac02_坂本竜之助
{
    internal class main
    {

        static void Main(string[] args)
        {
            Player_ player = new Player_();
            Player_ enemy = new Player_();

            BattleSimulator_ battleSimulator = new BattleSimulator_();

            Console.WriteLine("プレイヤーの名前を入力してください");
            player.Name = Console.ReadLine();
            Console.WriteLine("敵の名前を入力してください");
            enemy.Name = Console.ReadLine();

            player.Initialize();
            enemy.Initialize();

            player.Display();
            enemy.Display();

            battleSimulator.Battle(ref player, ref enemy);

            if(player.HP_ <= 0)
            {
                Console.WriteLine("プレイヤーの負け");
            }
            else if(enemy.HP_ <= 0)
            {
                Console.WriteLine("プレイヤーの勝ち");
            }

        }
    }
}
