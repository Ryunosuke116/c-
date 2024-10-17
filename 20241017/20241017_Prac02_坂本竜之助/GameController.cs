using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241017._20241017_Prac02_坂本竜之助
{
    public class GameController
    {
        const int number = 5;       //ゲーム回数

  

        public void Game()
        {
            //インスタンス化
            StartScene startScene = new StartScene();
            GameScene gameScene = new GameScene();
            ResultScene resultScene = new ResultScene();
            GameController gameController = new GameController();

            //スタート画面
            startScene.StandBy();
            //ゲームループ
            while (true)
            {
                //ゲーム画面
                for (int i = 0; i < number; i++)
                {
                    gameScene.PlayGame();
                }
                //リザルト画面
                resultScene.Result();

                if(ScoreManager.RestartOrEnd == 1)
                {
                    ScoreManager.Reset();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
