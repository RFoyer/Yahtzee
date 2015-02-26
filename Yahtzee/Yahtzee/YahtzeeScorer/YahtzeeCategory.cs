using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeScorer
{
    public enum YahtzeeCategory
    {
        Ones = 1,
        Twos = 2,
        Threes = 3,
        Fours = 4,
        Fives = 5,
        Sixes = 6,
        ThreeOfAKind,
        FourOfAKind,
        FullHouse = 25,
        SmallStraight = 30,
        LargeStraight = 40,
        Yahtzee = 50,
        Chance
    }
}
