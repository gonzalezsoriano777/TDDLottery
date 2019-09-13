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
            int[] lotteryNumber1 = new int[1] { 170 };
            var output = lotteryOne.SortNumbers(lotteryNumber1);
            Assert.AreEqual(lotteryNumber1, output);


        }
    }
}

