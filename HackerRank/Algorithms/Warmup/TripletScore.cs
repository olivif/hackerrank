/// <summary>
/// https://www.hackerrank.com/challenges/compare-the-triplets
/// </summary>
namespace HackerRank.Algorithms.Warmup
{
    using System;

    public class TripletScore : IComparable
    {
        public TripletScore(int clarity, int originality, int difficulty)
        {
            this.Clarity = clarity;
            this.Originality = originality;
            this.Difficulty = difficulty;
        }

        public int Clarity { get; set; }

        public int Originality { get; set; }

        public int Difficulty { get; set; }

        public int CompareTo(object obj)
        {
            var other = obj as TripletScore;
            var comparisonValue = 0;

            comparisonValue += (this.Clarity == other.Clarity) ? 0 : ((this.Clarity > other.Clarity) ? 1 : 0);
            comparisonValue += (this.Originality == other.Originality) ? 0 : ((this.Originality > other.Originality) ? 1 : 0);
            comparisonValue += (this.Difficulty == other.Difficulty) ? 0 : ((this.Difficulty > other.Difficulty) ? 1 : 0);

            return comparisonValue;
        }
    }
}
