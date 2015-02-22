using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeScorer
{
    public class CategoryChecker
    {
        public bool IsValidCategory(List<int> roll, YahtzeeCategory category)
        {
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
                            return true;
                        }
                    }
                }
            }

            if (category == YahtzeeCategory.ThreeOfAKind)
            {
                var numberGroupsInRoll = roll.GroupBy(r => r);

                foreach (var grouping in numberGroupsInRoll)
                {
                    if (grouping.Count() >= 3)
                    {
                        return true;
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
                        return true;
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
                            return true;
                        }
                        else if (roll.Contains(5) && roll.Contains(6))
                        {
                            return true;
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
                    return true;
                }

            }

            if (category == YahtzeeCategory.Yahtzee)
            {
                var checkForYahtzee = roll.Distinct();
                if (checkForYahtzee.Count() == 1)
                {
                    return true;
                }
            }

            if (category == YahtzeeCategory.Chance)
            {
                return true;
            }
            return false;
        }

        public bool IsNumericCategory(YahtzeeCategory category)
        {
            return (int)category <= 6;
        }

        internal bool IsFixedScoreCategory(YahtzeeCategory category)
        {
            return category == YahtzeeCategory.FullHouse
                || category == YahtzeeCategory.SmallStraight
                || category == YahtzeeCategory.LargeStraight
                || category == YahtzeeCategory.Yahtzee;
        }
    }
}
