// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FiveInARowService.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the FiveInARowService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Gomoku.Application
{
    using System.Collections.Generic;
    using System.Drawing;

    using Gomoku.Application.Contracts;

    /// <summary>
    /// The game class.
    /// </summary>
    public class FiveInARowService : IFiveInARowService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FiveInARowService"/> class.
        /// </summary>
        public FiveInARowService()
        {
            this.StonesInARowService = new StonesInARowService();
        }

        /// <summary>
        /// Gets or sets the stones in a row service.
        /// </summary>
        public IStonesInARowService StonesInARowService { get; set; }

        /// <summary>
        /// The check five in a row.
        /// </summary>
        /// <param name="stoneMoves">
        /// The stone moves.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool CheckFiveInARow(List<Point> stoneMoves, Point point)
        {
            if (this.CheckHorizontalFiveInARow(stoneMoves, point))
            {
                return true;
            }

            if (this.CheckVerticalFiveInARow(stoneMoves, point))
            {
                return true;
            }

            if (this.CheckBackwardDiagonalFiveInARow(stoneMoves, point))
            {
                return true;
            }

            if (this.CheckForwardDiagonalFiveInARow(stoneMoves, point))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// The check horizontal five in a row.
        /// </summary>
        /// <param name="stoneMoves">
        /// The stone moves.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool CheckHorizontalFiveInARow(List<Point> stoneMoves, Point point)
        {
            var leftSideStonesInARowCount = this.StonesInARowService.LeftCount(stoneMoves, point, 1);

            if (leftSideStonesInARowCount >= 5)
            {
                return true;
            }

            var rightSideStonesInARowCount = this.StonesInARowService.RightCount(stoneMoves, point, 0);
            leftSideStonesInARowCount += rightSideStonesInARowCount;

            return leftSideStonesInARowCount >= 5;
        }

        /// <summary>
        /// The check vertical five in a row.
        /// </summary>
        /// <param name="stoneMoves">
        /// The stone moves.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool CheckVerticalFiveInARow(List<Point> stoneMoves, Point point)
        {
            var topSideStonesInARowCount = this.StonesInARowService.TopCount(stoneMoves, point, 1);

            if (topSideStonesInARowCount >= 5)
            {
                return true;
            }

            var bottomSideStonesInARowCount = this.StonesInARowService.BottomCount(stoneMoves, point, 0);
            topSideStonesInARowCount += bottomSideStonesInARowCount;

            return topSideStonesInARowCount >= 5;
        }

        /// <summary>
        /// The check backward diagonal five in a row.
        /// </summary>
        /// <param name="stoneMoves">
        /// The stone moves.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool CheckBackwardDiagonalFiveInARow(List<Point> stoneMoves, Point point)
        {
            var topLeftSideStonesInARowCount = this.StonesInARowService.TopLeftCount(stoneMoves, point, 1);

            if (topLeftSideStonesInARowCount >= 5)
            {
                return true;
            }

            var bottomRightSideStonesInARowCount = this.StonesInARowService.BottomRightCount(stoneMoves, point, 0);
            topLeftSideStonesInARowCount += bottomRightSideStonesInARowCount;

            return topLeftSideStonesInARowCount >= 5;
        }

        /// <summary>
        /// The check forward diagonal five in a row.
        /// </summary>
        /// <param name="stoneMoves">
        /// The stone moves.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool CheckForwardDiagonalFiveInARow(List<Point> stoneMoves, Point point)
        {
            var topRightSideStonesInARowCount = this.StonesInARowService.TopRightCount(stoneMoves, point, 1);

            if (topRightSideStonesInARowCount >= 5)
            {
                return true;
            }

            var bottomLeftSideStonesInARowCount = this.StonesInARowService.BottomLeftCount(stoneMoves, point, 0);
            topRightSideStonesInARowCount += bottomLeftSideStonesInARowCount;

            return topRightSideStonesInARowCount >= 5;
        }
    }
}
