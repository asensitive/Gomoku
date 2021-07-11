// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FiveInARowServiceTests.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the FiveInARowServiceTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Gomoku.ApplicationTests
{
    using System.Collections.Generic;
    using System.Drawing;

    using Gomoku.Application;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The five in a row service tests.
    /// </summary>
    [TestClass]
    public class FiveInARowServiceTests
    {
        /// <summary>
        /// The check five in a row diagonal backward test.
        /// </summary>
        [TestMethod]
        public void CheckFiveInARowHorizontalTest()
        {
            var fiveInARowService = new FiveInARowService();

            var stoneMoves = new List<Point>()
                                 {
                                     new Point(0, 0),
                                     new Point(1, 0),
                                     new Point(2, 0),
                                     new Point(3, 0),
                                     new Point(4, 0)
                                 };

            var lastEnteredPoint = new Point(0, 0);

            var actualResult = fiveInARowService.CheckFiveInARow(stoneMoves, lastEnteredPoint);

            Assert.AreEqual(actualResult, true);
        }

        /// <summary>
        /// The check five in a row vertical test.
        /// </summary>
        [TestMethod]
        public void CheckFiveInARowVerticalTest()
        {
            var fiveInARowService = new FiveInARowService();

            var stoneMoves = new List<Point>()
                                 {
                                     new Point(0, 0),
                                     new Point(0, 1),
                                     new Point(0, 2),
                                     new Point(0, 3),
                                     new Point(0, 4)
                                 };

            var lastEnteredPoint = new Point(0, 4);

            var actualResult = fiveInARowService.CheckFiveInARow(stoneMoves, lastEnteredPoint);

            Assert.AreEqual(actualResult, true);
        }

        /// <summary>
        /// The check five in a row diagonal backward test.
        /// </summary>
        [TestMethod]
        public void CheckFiveInARowDiagonalBackwardTest()
        {
            var fiveInARowService = new FiveInARowService();

            var stoneMoves = new List<Point>()
                                 {
                                     new Point(0, 0),
                                     new Point(1, 1),
                                     new Point(2, 2),
                                     new Point(3, 3),
                                     new Point(4, 4)
                                 };

            var lastEnteredPoint = new Point(4, 4);

            var actualResult = fiveInARowService.CheckFiveInARow(stoneMoves, lastEnteredPoint);

            Assert.AreEqual(actualResult, true);
        }

        /// <summary>
        /// The check five in a row diagonal forward test.
        /// </summary>
        [TestMethod]
        public void CheckFiveInARowDiagonalForwardTest()
        {
            var fiveInARowService = new FiveInARowService();

            var stoneMoves = new List<Point>()
                                 {
                                     new Point(0, 14),
                                     new Point(1, 13),
                                     new Point(2, 12),
                                     new Point(3, 11),
                                     new Point(4, 10)
                                 };

            var lastEnteredPoint = new Point(2, 12);

            var actualResult = fiveInARowService.CheckFiveInARow(stoneMoves, lastEnteredPoint);

            Assert.AreEqual(actualResult, true);
        }

        /// <summary>
        /// The check five in a row diagonal backward test.
        /// </summary>
        [TestMethod]
        public void CheckFiveInARowHorizontalNegativeTest()
        {
            var fiveInARowService = new FiveInARowService();

            var stoneMoves = new List<Point>()
                                 {
                                     new Point(0, 0),
                                     new Point(1, 0),
                                     new Point(2, 0),
                                     new Point(3, 0),
                                     new Point(5, 0)
                                 };

            var lastEnteredPoint = new Point(5, 0);

            var actualResult = fiveInARowService.CheckFiveInARow(stoneMoves, lastEnteredPoint);

            Assert.AreNotEqual(actualResult, true);
        }

        /// <summary>
        /// The check five in a row vertical test.
        /// </summary>
        [TestMethod]
        public void CheckFiveInARowVerticalNegativeTest()
        {
            var fiveInARowService = new FiveInARowService();

            var stoneMoves = new List<Point>()
                                 {
                                     new Point(0, 9),
                                     new Point(0, 1),
                                     new Point(0, 2),
                                     new Point(0, 3),
                                     new Point(0, 4)
                                 };

            var lastEnteredPoint = new Point(0, 4);

            var actualResult = fiveInARowService.CheckFiveInARow(stoneMoves, lastEnteredPoint);

            Assert.AreNotEqual(actualResult, true);
        }

        /// <summary>
        /// The check five in a row diagonal backward test.
        /// </summary>
        [TestMethod]
        public void CheckFiveInARowDiagonalBackwardNegativeTest()
        {
            var fiveInARowService = new FiveInARowService();

            var stoneMoves = new List<Point>()
                                 {
                                     new Point(0, 0),
                                     new Point(1, 1),
                                     new Point(7, 7),
                                     new Point(3, 3),
                                     new Point(4, 4)
                                 };

            var lastEnteredPoint = new Point(4, 4);

            var actualResult = fiveInARowService.CheckFiveInARow(stoneMoves, lastEnteredPoint);

            Assert.AreNotEqual(actualResult, true);
        }

        /// <summary>
        /// The check five in a row diagonal forward test.
        /// </summary>
        [TestMethod]
        public void CheckFiveInARowDiagonalForwardNegativeTest()
        {
            var fiveInARowService = new FiveInARowService();

            var stoneMoves = new List<Point>()
                                 {
                                     new Point(0, 14),
                                     new Point(1, 13),
                                     new Point(2, 12),
                                     new Point(3, 11),
                                     new Point(5, 9)
                                 };

            var lastEnteredPoint = new Point(5, 9);

            var actualResult = fiveInARowService.CheckFiveInARow(stoneMoves, lastEnteredPoint);

            Assert.AreNotEqual(actualResult, true);
        }
    }
}