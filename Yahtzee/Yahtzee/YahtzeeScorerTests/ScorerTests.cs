﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YahtzeeScorer;

namespace YahtzeeScorerTests
{
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
        [TestMethod]
        public void Score__WhenRollIs11112_andCategoryFourOfAKind_Returns6()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 1, 1, 1, 2 };
            var category = YahtzeeCategory.FourOfAKind;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(6, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs11111_andCategoryFourOfAKind_Returns5()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 1, 1, 1, 1 };
            var category = YahtzeeCategory.FourOfAKind;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(5, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs11122_andCategoryFourOfAKind_Returns0()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 1, 1, 2, 2 };
            var category = YahtzeeCategory.FourOfAKind;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(0, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs11122_andCategoryFullHouse_Returns25()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 1, 1, 2, 2 };
            var category = YahtzeeCategory.FullHouse;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(25, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs11112_andCategoryFullHouse_Returns0()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 1, 1, 1, 2 };
            var category = YahtzeeCategory.FullHouse;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(0, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs12345_andCategorySmallStraight_Returns30()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 2, 3, 4, 5 };
            var category = YahtzeeCategory.SmallStraight;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(30, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs12346_andCategorySmallStraight_Returns30()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 2, 3, 4, 6 };
            var category = YahtzeeCategory.SmallStraight;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(30, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs12356_andCategorySmallStraight_Returns0()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 2, 3, 5, 6 };
            var category = YahtzeeCategory.SmallStraight;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(0, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs11234_andCategorySmallStraight_Returns30()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 1, 2, 3, 4 };
            var category = YahtzeeCategory.SmallStraight;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(30, actual);
        }
        [TestMethod]
        public void Score__WhenRollIs54123_andCategorySmallStraight_Returns30()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 5, 4, 1, 2, 3 };
            var category = YahtzeeCategory.SmallStraight;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(30, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs54423_andCategorySmallStraight_Returns30()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 5, 4, 4, 2, 3 };
            var category = YahtzeeCategory.SmallStraight;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(30, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs13456_andCategorySmallStraight_Returns30()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 3, 4, 5, 6 };
            var category = YahtzeeCategory.SmallStraight;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(30, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs12354_andCategoryLargeStraight_Returns40()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 2, 3, 5, 4 };
            var category = YahtzeeCategory.LargeStraight;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(40, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs65432_andCategoryLargeStraight_Returns40()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 6, 5, 4, 3, 2 };
            var category = YahtzeeCategory.LargeStraight;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(40, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs12346_andCategoryLargeStraight_Returns0()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 1, 2, 3, 4, 6 };
            var category = YahtzeeCategory.LargeStraight;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs22222_andCategoryLargeStraight_Returns0()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 2, 2, 2, 2, 2 };
            var category = YahtzeeCategory.LargeStraight;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs22222_andCategoryYahtzee_Returns50()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 2, 2, 2, 2, 2 };
            var category = YahtzeeCategory.Yahtzee;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(50, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs22223_andCategoryYahtzee_Returns0()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 2, 2, 2, 2, 3 };
            var category = YahtzeeCategory.Yahtzee;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Score__WhenRollIs55555_andCategoryChance_Returns25()
        {
            // arrange
            var scorer = new Scorer();
            var roll = new List<int> { 5, 5, 5, 5, 5 };
            var category = YahtzeeCategory.Chance;

            //act
            var actual = scorer.Score(roll, category);

            //assert
            Assert.AreEqual(25, actual);
        }


    }
}
