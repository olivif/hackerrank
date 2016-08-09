namespace HackerRank.Algorithms.Warmup
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TripletsTests
    {
        [TestMethod]
        public void TripletScore_Compare_LessThan()
        {
            // Arrange
            var triplet1 = new TripletScore(1, 2, 3);
            var triplet2 = new TripletScore(4, 2, 3);

            // Act
            var comparisonValue = triplet1.CompareTo(triplet2);

            // Assert
            Assert.AreEqual(0, comparisonValue);
        }

        [TestMethod]
        public void TripletScore_Compare_GreaterThan()
        {
            // Arrange
            var triplet1 = new TripletScore(1, 2, 3);
            var triplet2 = new TripletScore(0, 2, 3);

            // Act
            var comparisonValue = triplet1.CompareTo(triplet2);

            // Assert
            Assert.AreEqual(1, comparisonValue);
        }

        [TestMethod]
        public void TripletScore_Compare_Equal()
        {
            // Arrange
            var triplet = new TripletScore(1, 2, 3);

            // Act
            var comparisonValue = triplet.CompareTo(triplet);

            // Assert
            Assert.AreEqual(0, comparisonValue);
        }

        [TestMethod]
        public void TripletScore_Compare_HackerRank()
        {
            // Arrange
            var triplet1 = new TripletScore(5, 6, 7);
            var triplet2 = new TripletScore(3, 6, 10);

            // Act
            var comparisonValue1 = triplet1.CompareTo(triplet2);
            var comparisonValue2 = triplet2.CompareTo(triplet1);

            // Assert
            Assert.AreEqual(1, comparisonValue1);
            Assert.AreEqual(1, comparisonValue2);
        }
    }
}
