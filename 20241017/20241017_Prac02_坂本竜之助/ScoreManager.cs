using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_._20241017._20241017_Prac02_坂本竜之助
{
    public class ScoreManager
    {
        private static int currentScore = 0;       //現在のスコア
        private static int restartOrEnd = 0;        //リスタートするかしないか    

        public static int RestartOrEnd
        {
            get { return restartOrEnd; }
            set { restartOrEnd = value; }
        }

        public static int CurrentScore()
        {
            return  currentScore;
        }
        /// <summary>
        /// スコアを加算
        /// </summary>
        /// <param name="points"></param>
        public static void AddScore(int points)
        {
            currentScore += points;
        }
        
        /// <summary>
        /// スコアをリセット
        /// </summary>
        public static void Reset()
        {
            currentScore = 0;
        }
        /// <summary>
        /// 指定された閾値を超えているか
        /// </summary>
        /// <param name="threshold"></param>
        public static bool IsHighScore(int threshold)
        {
            //超えていたらtrue
           if(threshold < currentScore)
            {
                return true;
            }
           //超えていない場合はfalse
           return false;
        }

    }
}
