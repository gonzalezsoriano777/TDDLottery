using NUnit.Framework;
using System;
using LotteryService;

namespace LotteryTest
{
    class LotteryFour
    {
        lotteryService lotteryFour = new lotteryService();

        [Test]
        public void ReturnTenNumSorted()
        {
            int[] lotteryNumber4 = new int[10] { 70, 40, 60, 80, 160, 4820, 583, 83, 6942, 7 };
            var output = lotteryFour.SortNumbers(lotteryNumber4);
            int[] fakeLottery = new int[10] { 58382, 5839, 5822, 6324, 5722, 5932, 942, 5, 6, 2 };
            var secondOuput = lotteryFour.SortNumbers(fakeLottery);
            Assert.AreEqual(lotteryNumber4, output);
        }
    }
}

