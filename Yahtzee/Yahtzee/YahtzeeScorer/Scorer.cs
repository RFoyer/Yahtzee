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

            if (IsNumberCategory(category))
            {
                for (var i = 0; i <= 4; i++)
                {
                    var currentNumber = roll[i];
                    if (currentNumber == (int)category)
                    {
                        score += (int)category;
                    }
                }
            }

            if (category == YahtzeeCategory.FullHouse)
            {
                var distinctNumbersRolled = roll.Distinct();

                if (distinctNumbersRolled.Count() == 2)
                {
                    foreach (var number in distinctNumbersRolled)
                    {
                        var howManyOfThisNumberinRoll = roll.Count(r => r == number);
                        if (howManyOfThisNumberinRoll == 3)
                        {
                            score = 25;
                            break;
                        }
                    }
                }
            }

            if (category == YahtzeeCategory.ThreeOfAKind)
            {
                var howManyOfThisNumberinRoll = roll.GroupBy(r => r);
                foreach (var number in howManyOfThisNumberinRoll)
                {
                    if (number.Count() >= 3)
                    {
                        score = roll.Sum();
                        break;
                    }
                }

            }

            if (category == YahtzeeCategory.FourOfAKind)
            {
                var howManyOfThisNumberinRoll = roll.GroupBy(r => r);
                foreach (var number in howManyOfThisNumberinRoll)
                {
                    if (number.Count() >= 4)
                    {
                        score = roll.Sum();
                        break;
                    }
                }

            }


            if (category == YahtzeeCategory.SmallStraight)
            {
                var distinctOrderedRoll = roll.Distinct().ToList();
                distinctOrderedRoll.Sort();

                if (distinctOrderedRoll.Count() >= 4)
                {
                    for (var i = 0; i <= 1; i++)
                    {
                        if (distinctOrderedRoll[i] + 1 == distinctOrderedRoll[i + 1] &&
                            distinctOrderedRoll[i + 1] + 1 == distinctOrderedRoll[i + 2] &&
                            distinctOrderedRoll[i + 2] + 1 == distinctOrderedRoll[i + 3])
                        {
                            score = 30;
                            break;
                        }
                    }
                }

            }

            if (category == YahtzeeCategory.LargeStraight)
            {
                var distinctRoll = roll.Distinct();

                if (distinctRoll.Count() == 5 &&
                    !(distinctRoll.Contains(1) && distinctRoll.Contains(6)))
                {
                    score = 40;
                }

            }
            
            if (category == YahtzeeCategory.Yahtzee)
            {
                var checkForYahtzee = roll.Distinct();
                if (checkForYahtzee.Count() == 1)
                {
                    score = 50;
                }
            }

            if (category == YahtzeeCategory.Chance)
            {
                score = roll.Sum();
            }

            return score;
        }

        private static bool IsNumberCategory(YahtzeeCategory category)
        {
            return (int)category <= 6;
        }
    }
}
