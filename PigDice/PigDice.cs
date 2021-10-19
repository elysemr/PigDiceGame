using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice
{
    class PigDice
    {
        private Random rnd = new Random();

        public int RunToHighScore(int highScore)
        {
            Console.WriteLine($"Begin: {DateTime.Now}");
            var score = PlayPigDice();
            var currHighScore = 0;
            while(score < highScore)
            {
                score = PlayPigDice();
                if(score > currHighScore)
                {
                    currHighScore = score;
                    Console.WriteLine($"New high score is  {score}");
                }
            }
            Console.WriteLine($"End: {DateTime.Now}");
            return score;
        }

        public int PlayPigDice()
        {
            var score = 0;
            var roll = RollDice();
            while(roll != 1)
            {
                score += roll;
                roll = RollDice();
            }
            return score;
        }
        private int RollDice()
        {
            return rnd.Next(1, 7);
        }
    }
}
