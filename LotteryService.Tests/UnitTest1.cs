using NUnit.Framework;
using LotteryService;

namespace Tests
{
    public class Tests
    {
        lotteryService _testService = new lotteryService ();
        [Test]
        public void return_Array()
        {
            int[]lotteryNumbers0 = new int[0];
            var output = _testService.SortNumbers(lotteryNumbers0);
            Assert.AreEqual(new int[0],output);

        }
    }
}