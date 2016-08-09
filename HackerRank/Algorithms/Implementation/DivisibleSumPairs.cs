namespace HackerRank.Algorithms.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public void ReadInput(ref IList<int> list, ref int k)
        {
            string line;
            string[] split;

            // n k
            line = Console.ReadLine();
            split = line.Split(' ');
            var numbers = split.ToList().Select(number => int.Parse(number)).ToList();
            var n = numbers[0];
            k = numbers[1];

            // numbers
            line = Console.ReadLine();
            split = line.Split(' ');
            list = split.ToList().Select(number => int.Parse(number)).ToList();
        }

        public int GetPairs(IList<int> list, int k)
        {
            var count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (i < j)
                    {
                        if ((list[i] + list[j]) % k == 0)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        static void Main(String[] args)
        {
            var divisibleSumPairs = new Solution();

            // Read input
            IList<int> list = null;
            int k = 0;
            divisibleSumPairs.ReadInput(ref list, ref k);

            // Get count
            var count = divisibleSumPairs.GetPairs(list, k);
            Console.WriteLine(count);
        }
    }
}
