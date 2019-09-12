using System;

namespace LotteryService
{
    public class lotteryService
    {
        public int[] SortNumbers(int[] lotteryNums)
        {

            Array.Sort(lotteryNums);
            return lotteryNums;
            
        }
    }
}
