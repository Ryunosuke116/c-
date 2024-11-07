using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace c_._20241107._20241107_Prac02_坂本竜之助
{
        public class BattleSimulator_
        {
            
            public void Battle(ref Player_ player, ref Player_ enemy)
            {
                Random random = new Random();

                while (true)
                {
                    Console.WriteLine("プレイヤーの攻撃");
                    int playerAttack = random.Next(5, player.Attack);
                    enemy.TakeDamage(playerAttack);
                    Console.WriteLine($"{playerAttack}ダメージ");
                    Console.WriteLine($"{enemy.Name}の残りHP{enemy.HP_}");

                    Console.WriteLine("プレイヤーの攻撃");
                    int enemyAttack = random.Next(5, enemy.Attack);
                    player.TakeDamage(enemyAttack);
                    Console.WriteLine($"{enemyAttack}ダメージ");
                    Console.WriteLine($"{player.Name}の残りHP{player.HP_}");
                    if(player.HP_ <= 0 || enemy.HP_ <= 0)
                    {
                        break;
                    }
                }

            }
        }
    internal class BattleSimulator
    {


    }
}
