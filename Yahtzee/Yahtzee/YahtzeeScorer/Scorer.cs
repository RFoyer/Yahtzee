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

            // added "if" block here for optimization. else the loop always executes
            // regardless of what category is passed into the Score method.

            if ((int)category <= 6)
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

            // Charlie's Idea: (breaks added for optimization; could add "return score"
            // instead of break (right?) but there are possible bonus points in Yahtzee)

            /*
            if (category == YahtzeeCategory.ThreeOfAKind)
            {
                var distinctNumbersRolled = roll.Distinct();

                if (distinctNumbersRolled.Count() <= 3)
                {
                    foreach (var number in distinctNumbersRolled)
                    {
                        var howManyOfThisNumberinRoll = roll.Count(r => r == number);
                        if (howManyOfThisNumberinRoll >= 3)
                        {
                            score = roll.Sum();
                            break;
                        }
                    }
                }

            }
            */

            // Extension of Charlie's for FourOfAKind:

            /*
            if (category == YahtzeeCategory.FourOfAKind)
            {
                var distinctNumbersRolled = roll.Distinct();

                if (distinctNumbersRolled.Count() <= 2)
                {
                    foreach (var number in distinctNumbersRolled)
                    {
                        var howManyOfThisNumberinRoll = roll.Count(r => r == number);
                        if (howManyOfThisNumberinRoll >= 4)
                        {
                            score = roll.Sum();
                            break;
                        }
                    }
                }
            }
            */

            // Extension of Charlie's idea for FullHouse:

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

            // My idea for three/four of a kind:

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


            // Second idea. I don't like the following, but it does seem to be 
            // a simpler (but is it less expensive?) way of doing small/large straight.

            /*
            if (category == YahtzeeCategory.SmallStraight)
            {
                var rollPlacedInOrder = roll.Distinct().OrderBy(r => r);
                
                if (rollPlacedInOrder.Count() >= 4)
                {
                    foreach (var number in rollPlacedInOrder)
                    {
                        if (rollPlacedInOrder.Contains(1)
                            && rollPlacedInOrder.Contains(2)
                            && rollPlacedInOrder.Contains(3)
                            && rollPlacedInOrder.Contains(4))
                        {
                            score = 30;
                        }
                        if (rollPlacedInOrder.Contains(2)
                            && rollPlacedInOrder.Contains(3)
                            && rollPlacedInOrder.Contains(4)
                            && rollPlacedInOrder.Contains(5))
                        {
                            score = 30;
                        }
                        if (rollPlacedInOrder.Contains(3)
                            && rollPlacedInOrder.Contains(4)
                            && rollPlacedInOrder.Contains(5)
                            && rollPlacedInOrder.Contains(6))
                        {
                            score = 30;
                        }
                    
                    }
                }
            }

            if (category == YahtzeeCategory.LargeStraight)
            {
                var rollPlacedInOrder = roll.Distinct().OrderBy(r => r);
                
                if(rollPlacedInOrder.Count() == 5)
                {
                    foreach (var number in rollPlacedInOrder)
                    {
                        if (rollPlacedInOrder.Contains(1)
                            && rollPlacedInOrder.Contains(2)
                            && rollPlacedInOrder.Contains(3)
                            && rollPlacedInOrder.Contains(4)
                            && rollPlacedInOrder.Contains(5))
                        {
                            score = 40;
                        }
                        if (rollPlacedInOrder.Contains(2)
                            && rollPlacedInOrder.Contains(3)
                            && rollPlacedInOrder.Contains(4)
                            && rollPlacedInOrder.Contains(5)
                            && rollPlacedInOrder.Contains(6))
                        {
                            score = 40;
                        }
                    }
                }
            }
            */

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
    }
}
