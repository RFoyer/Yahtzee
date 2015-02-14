using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YahtzeeScorer;

namespace YahtzeeScorerTests
{

    /*

Ones, Twos, Threes, Fours, Fives, Sixes: The player scores the sum of the dice that reads one, two, three, four, five or six, respectively. For example, 1, 1, 2, 4, 4 placed on "fours" gives 8 points.
Pair: The player scores the sum of the two highest matching dice. For example, 3, 3, 3, 4, 4 placed on "pair" gives 8.
Two pairs: If there are two pairs of dice with the same number, the player scores the sum of these dice. If not, the player scores 0. For example, 1, 1, 2, 3, 3 placed on "two pairs" gives 8.
Three of a kind: If there are three dice with the same number, the player scores the sum of these dice. Otherwise, the player scores 0. For example, 3, 3, 3, 4, 5 places on "three of a kind" gives 9.
Four of a kind: If there are four dice with the same number, the player scores the sum of these dice. Otherwise, the player scores 0. For example, 2, 2, 2, 2, 5 places on "four of a kind" gives 8.
Small straight: If the dice read 1,2,3,4,5, the player scores 15 (the sum of all the dice), otherwise 0.
Large straight: If the dice read 2,3,4,5,6, the player scores 20 (the sum of all the dice), otherwise 0.
Full house: If the dice are two of a kind and three of a kind, the player scores the sum of all the dice. For example, 1,1,2,2,2 placed on "full house" gives 8. 4,4,4,4,4 is not "full house".
Yahtzee: If all dice are the have the same number, the player scores 50 points, otherwise 0.
Chance: The player gets the sum of all dice, no matter what they read.
     */
    [TestClass]
    public class ScorerTests
    {
        [TestMethod]
        public void Score__WhenRollIs22456_AndCategoryOnes_Returns0()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 2, 2, 4, 5, 6 };
            var category = YahtzeeCategory.Ones;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs12456_AndCategoryOnes_Returns1()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 2, 4, 5, 6 };
            var category = YahtzeeCategory.Ones;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs12451_AndCategoryOnes_Returns2()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 2, 4, 5, 1 };
            var category = YahtzeeCategory.Ones;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs32451_AndCategoryOnes_Returns1()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 3, 2, 4, 5, 1 };
            var category = YahtzeeCategory.Ones;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs11111_AndCategoryOnes_Returns5()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 1, 1, 1, 1 };
            var category = YahtzeeCategory.Ones;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs11111_AndCategoryTwos_Returns0()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 1, 1, 1, 1 };
            var category = YahtzeeCategory.Twos;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs11112_AndCategoryTwos_Returns2()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 1, 1, 1, 2 };
            var category = YahtzeeCategory.Twos;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs12324_AndCategoryTwos_Returns4()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 2, 3, 2, 4 };
            var category = YahtzeeCategory.Twos;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs11111_AndCategoryThrees_Returns0()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 1, 1, 1, 1 };
            var category = YahtzeeCategory.Threes;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs11113_AndCategoryThrees_Returns3()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 1, 1, 1, 3 };
            var category = YahtzeeCategory.Threes;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs45611_AndCategoryFours_Returns4()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 4, 5, 6, 1, 1 };
            var category = YahtzeeCategory.Fours;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs45611_AndCategoryFives_Returns5()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 4, 5, 6, 1, 1 };
            var category = YahtzeeCategory.Fives;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs45611_AndCategorySixes_Returns6()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 4, 5, 6, 1, 1 };
            var category = YahtzeeCategory.Sixes;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(6, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs11122_andCategoryThreeOfAKind_Returns7()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 1, 1, 2, 2 };
            var category = YahtzeeCategory.ThreeOfAKind;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(7, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs22211_andCategoryThreeOfAKind_Returns8()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 2, 2, 2, 1, 1 };
            var category = YahtzeeCategory.ThreeOfAKind;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(8, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs33334_andCategoryThreeOfAKind_Returns16()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 3, 3, 3, 3, 4 };
            var category = YahtzeeCategory.ThreeOfAKind;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(16, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs66666_andCategoryThreeOfAKind_Returns30()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 6, 6, 6, 6, 6 };
            var category = YahtzeeCategory.ThreeOfAKind;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(30, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs12345_andCategoryThreeOfAKind_Returns0()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 2, 3, 4, 5 };
            var category = YahtzeeCategory.ThreeOfAKind;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(0, actual);
        }
    }
}
