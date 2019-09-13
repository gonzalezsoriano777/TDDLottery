using NUnit.Framework;
using System;
using LotteryService;

namespace LotteryTest
{
    public class LotteryOne
    {
        lotteryService lotteryOne = new lotteryService(); 

        [Test]
        public void ReturnOneNumSorted()
        {
            int[] lotteryNumber0 = new int[1] { 170 };
            var output = lotteryOne.SortNumbers(lotteryNumber0);
            Assert.AreEqual(lotteryNumber0, output);


        }
    }
}

