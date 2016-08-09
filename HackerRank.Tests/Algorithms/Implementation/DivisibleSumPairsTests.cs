using System;
namespace HackerRank.Algorithms.Implementation
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class DivisibleSumPairsTests
    {
        [TestMethod]
        public void DivisibleSumPairs_HackerRank()
        {
            // Arrange
            //6 3
            //1 3 2 6 1 2
            var list = new List<int>() { 1, 3, 2, 6, 1, 2 };
            var k = 3;
            var divisibleSumPairs = new Solution();

            // Act
            var count = divisibleSumPairs.GetPairs(list, k);

            // Assert
            Assert.AreEqual(5, count);
        }
    }
}
