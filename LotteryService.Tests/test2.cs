using NUnit.Framework;
using System;
using LotteryService;

namespace LotteryTest
{
    class LotteryTwo
    {
        lotteryService lotteryTwo = new lotteryService();

        [Test]
        public void ReturnTwoNumSorted()
        {
            int[] lotteryNumber2 = new int[2] { 170, 110 };
            var output = lotteryTwo.SortNumbers(lotteryNumber2);
            int[] fakeLottery = new int[2] { 170, 110 };
            Assert.AreEqual(lotteryNumber2, output);

        }
    }
}


