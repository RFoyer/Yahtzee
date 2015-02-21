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
                var numberBeingChecked = (int)category;
                var distinctNumbersRolled = roll.Distinct();
                foreach (var number in distinctNumbersRolled)
                {
                    if (number == numberBeingChecked)
                    {
                        score = roll.Count(r => r == number) * numberBeingChecked;
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
                var distinctRoll = roll.Distinct();

                if (distinctRoll.Count() >= 4)
                {
                        if (roll.Contains(3) && roll.Contains(4))
                        {
                            if (roll.Contains(2) && (roll.Contains(1) || roll.Contains(5)))
                            {
                                score = 30;
                            }
                            else if (roll.Contains(5) && roll.Contains(6))
                            {
                                score = 30;
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
