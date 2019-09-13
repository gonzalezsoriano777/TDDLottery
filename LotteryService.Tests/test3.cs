using NUnit.Framework;
using System;
using LotteryService;


namespace LotteryTest
{
    class LotteryThree
    {
        lotteryService lotteryThree = new lotteryService();

        [Test]
        public void ReturnThreeNumSorted()
        {
            int[] lotteryNumber3 = new int[3] { 110, 170, 90 };
            var output = lotteryThree.SortNumbers(lotteryNumber3);
            int[] fakeLottery = new int[3] { 70, 110, 180 };
            Assert.AreEqual(lotteryNumber3, output);
        }
    }
}

