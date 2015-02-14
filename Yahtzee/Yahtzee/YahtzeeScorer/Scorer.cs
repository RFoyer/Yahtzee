using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeScorer
{
    public class Scorer
    {
        public int Score(List<int> roll, YahtzeeCategory category)
        {
            var score = 0;

            for (var i = 0; i <= 4; i++)
            {
                var currentNumber = roll[i];
                if (currentNumber == (int)category)
                {
                    score += (int)category;
                }
            }
            

            return score;
        }
    }
}
