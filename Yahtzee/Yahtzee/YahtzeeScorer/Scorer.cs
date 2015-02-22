using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeScorer
{
    public class Scorer
    {
        private CategoryChecker _categoryChecker;

        public Scorer()
        {
            _categoryChecker = new CategoryChecker();
        }

        public int Score(List<int> roll, YahtzeeCategory category)
        {
            var score = 0;

            if (_categoryChecker.IsNumericCategory(category))
            {
                var categoryValue = (int)category;
                var howManyOfThisCategory = roll.Count(num => num == categoryValue);
                score = howManyOfThisCategory * categoryValue;
            }

            if (_categoryChecker.IsFixedScoreCategory(category)
                && _categoryChecker.IsValidCategory(roll, category))
            {
                var categoryValue = (int)category;
                score = categoryValue;
            }

            if (
                (category == YahtzeeCategory.ThreeOfAKind
                || category == YahtzeeCategory.FourOfAKind
                || category == YahtzeeCategory.Chance)
                &&
                _categoryChecker.IsValidCategory(roll, category)
                )
            {
                score = roll.Sum();
            }

            return score;
        }
    }

}
