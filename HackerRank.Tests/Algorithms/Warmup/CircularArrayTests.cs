namespace HackerRank.Algorithms.Warmup
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CircularArrayTests
    {
        [TestMethod]
        public void CircularArray_HackerRank()
        {
            // Arrange
            //3 2 3
            //1 2 3
            //0
            //1 
            //2
            var list = new List<int>() { 1, 2, 3 };
            var n = list.Count;
            var q = 2;
            var circularArray = new CircularArray();

            // Act
            circularArray.RotateArray(list, q);

            // Assert
            Assert.AreEqual(2, list[0]);
            Assert.AreEqual(3, list[1]);
            Assert.AreEqual(1, list[2]);
        }
    }
}
