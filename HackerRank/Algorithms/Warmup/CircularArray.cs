/// <summary>
/// https://www.hackerrank.com/challenges/circular-array-rotation
/// </summary>
namespace HackerRank.Algorithms.Warmup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CircularArray
    {
        public void ReadInput(ref IList<int> list, ref IList<int> queries, ref int k)
        {
            string line;
            string[] split;

            // n k q
            line = Console.ReadLine();
            split = line.Split(' ');
            var numbers = split.ToList().Select(number => int.Parse(number)).ToList();
            var n = numbers[0];
            k = numbers[1];
            var q = numbers[2];

            // numbers
            line = Console.ReadLine();
            split = line.Split(' ');
            list = split.ToList().Select(number => int.Parse(number)).ToList();

            // queries
            queries = new List<int>();
            for (int i = 0; i < q; i++)
            {
                line = Console.ReadLine();
                var query = int.Parse(line);
                queries.Add(query);
            }
        }

        public void RotateArray(IList<int> list, int q)
        {
            // Rotate
            for (int i = 0; i < q; i++)
            {
                var lastIndex = list.Count - 1;
                // Store the last element
                var lastElement = list[lastIndex];
                // Remove it
                list.RemoveAt(lastIndex);
                // Store it at the front of the list
                list.Insert(0, lastElement);
            }
        }
        static void Main(String[] args)
        {
            var circularArray = new CircularArray();

            // Read input
            IList<int> list = null;
            IList<int> queries = null;
            int k = 0;
            circularArray.ReadInput(ref list, ref queries, ref k);

            // Rotate
            circularArray.RotateArray(list, k);

            // Go through queries and make them
            foreach(var q in queries)
            {
                Console.WriteLine(list[q]);
            }
        }
    }
}