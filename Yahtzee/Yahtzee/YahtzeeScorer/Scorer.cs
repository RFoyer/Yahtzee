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

            if (category == YahtzeeCategory.ThreeOfAKind)
            {
                var numberCheck = 1;
                for (int i = 0; i <= 5; i++)
                {
                    var numberRepeats = 0;
                    for (int j = 0; j <= 4; j++)
                    {
                        var currentNumber = roll[j];
                        if (currentNumber == numberCheck)
                        {
                            numberRepeats++;
                        }
                        if (numberRepeats >= 3 && j == 4)
                        {
                            score = roll.Sum();
                        }
                    }
                    numberCheck++;
                }

            }



            return score;
        }
    }
}
