

namespace c_._20240905
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            //インスタンス化
            Character[] characters = new Character[5];
            System system = new System();

            //派生クラスのインスタンス化
            characters[0] = new Goblin();
            characters[1] = new Kobold();
            characters[2] = new Warrior();
            characters[3] = new Mage();
            characters[4] = new Archer();

            while (true)
            {
                //味方の攻撃
                for (int i = 2; i < 5; i++)
                {
                    //HPが0以上の場合のみ動ける
                    if (characters[i].GetHealth() > 0)
                    {
                        characters[i].Attack();
                        system.Calculation(characters[i], characters[characters[i].GetChose()]);
                        system.Display(characters[characters[i].GetChose()]);
                    }

                    //敵が全滅した場合終了
                    if (characters[0].GetHealth() <= 0 && characters[1].GetHealth() <= 0 ||
                         characters[2].GetHealth() <= 0 && characters[3].GetHealth() <= 0 &&
                         characters[4].GetHealth() <= 0)
                    {
                        break;
                    }
                }    
                //enemyの攻撃
                for (int i = 0; i < 2; i++)
                {
                    //HPが0以上の場合のみ動ける
                    if (characters[i].GetHealth() > 0)
                    {
                        characters[i].Attack();
                        system.Calculation(characters[i], characters[characters[i].GetChose()]);
                        system.Display(characters[characters[i].GetChose()]);     
                    }

                    //敵が全滅した場合終了
                    if (characters[0].GetHealth() <= 0 && characters[1].GetHealth() <= 0 ||
                        characters[2].GetHealth() <= 0 && characters[3].GetHealth() <= 0 &&
                        characters[4].GetHealth() <= 0)
                    {
                        break;
                    }
                }

            }



        }
    }
}
