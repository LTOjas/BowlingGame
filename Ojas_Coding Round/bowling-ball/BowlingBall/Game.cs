using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Game
    {
        public int score = 0;
        public int bonus = 0;
        List<int> pinsVal = new List<int>();

        public void Roll(int pins)
        {
            pinsVal.Add(pins);
            score += pins;
        }

        public int GetScore()
        {
            // Returns the final score of the game.
            calulateBonus();
            return score + bonus;
        }

        public void calulateBonus()
        {
            for (int i = 0; i < pinsVal.Count(); i++)
            {
                if (i <= (pinsVal.Count() - 2))
                {
                    if (pinsVal[i] == 10)
                    {
                        bonus += pinsVal[i + 1];
                        bonus += pinsVal[i + 2];
                    }

                    if(((pinsVal[i] + pinsVal[i+1]) == 10) && (pinsVal[i-1] != 10))
                    {
                        bonus += pinsVal[i + 2];
                    }
                }
            }
        }
    }
}
