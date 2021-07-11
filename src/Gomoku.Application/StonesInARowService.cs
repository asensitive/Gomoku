// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StonesInARowService.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the StonesInARowService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Gomoku.Application
{
    using System.Collections.Generic;
    using System.Drawing;

    using Gomoku.Application.Contracts;
    using Gomoku.Domain;

    /// <summary>
    /// The stones in a row service.
    /// </summary>
    public class StonesInARowService : IStonesInARowService
    {
        /// <inheritdoc />
        public int LeftCount(List<Point> stoneMoves, Point point, int stonesInARowCount)
        {
            if (point.X == 0)
            {
                return stonesInARowCount;
            }

            var leftPoint = Board.BoardPoints[point.X - 1, point.Y];

            if (stoneMoves.Contains(leftPoint))
            {
                stonesInARowCount++;
                return this.LeftCount(stoneMoves, leftPoint, stonesInARowCount);
            }

            return stonesInARowCount;
        }

        /// <inheritdoc />
        public int RightCount(List<Point> stoneMoves, Point point, int stonesInARowCount)
        {
            if (point.X == 14)
            {
                return stonesInARowCount;
            }

            var rightPoint = Board.BoardPoints[point.X + 1, point.Y];

            if (stoneMoves.Contains(rightPoint))
            {
                stonesInARowCount++;
                return this.RightCount(stoneMoves, rightPoint, stonesInARowCount);
            }

            return stonesInARowCount;
        }

        /// <inheritdoc />
        public int TopCount(List<Point> stoneMoves, Point point, int stonesInARowCount)
        {
            if (point.Y == 0)
            {
                return stonesInARowCount;
            }

            var adjacentPoint = Board.BoardPoints[point.X, point.Y - 1];

            if (stoneMoves.Contains(adjacentPoint))
            {
                stonesInARowCount++;
                return this.TopCount(stoneMoves, adjacentPoint, stonesInARowCount);
            }

            return stonesInARowCount;
        }

        /// <inheritdoc />
        public int BottomCount(List<Point> stoneMoves, Point point, int stonesInARowCount)
        {
            if (point.Y == 14)
            {
                return stonesInARowCount;
            }

            var adjacentPoint = Board.BoardPoints[point.X, point.Y + 1];

            if (stoneMoves.Contains(adjacentPoint))
            {
                stonesInARowCount++;
                return this.BottomCount(stoneMoves, adjacentPoint, stonesInARowCount);
            }

            return stonesInARowCount;
        }

        /// <inheritdoc />
        public int TopLeftCount(List<Point> stoneMoves, Point point, int stonesInARowCount)
        {
            if (point.X == 0 || point.Y == 0)
            {
                return stonesInARowCount;
            }

            var adjacentPoint = Board.BoardPoints[point.X - 1, point.Y - 1];

            if (stoneMoves.Contains(adjacentPoint))
            {
                stonesInARowCount++;
                return this.TopLeftCount(stoneMoves, adjacentPoint, stonesInARowCount);
            }

            return stonesInARowCount;
        }

        /// <inheritdoc />
        public int BottomRightCount(List<Point> stoneMoves, Point point, int stonesInARowCount)
        {
            if (point.X == 14 || point.Y == 14)
            {
                return stonesInARowCount;
            }

            var adjacentPoint = Board.BoardPoints[point.X + 1, point.Y + 1];

            if (stoneMoves.Contains(adjacentPoint))
            {
                stonesInARowCount++;
                return this.BottomRightCount(stoneMoves, adjacentPoint, stonesInARowCount);
            }

            return stonesInARowCount;
        }

        /// <inheritdoc />
        public int TopRightCount(List<Point> stoneMoves, Point point, int stonesInARowCount)
        {
            if (point.X == 14 || point.Y == 0)
            {
                return stonesInARowCount;
            }

            var adjacentPoint = Board.BoardPoints[point.X + 1, point.Y - 1];

            if (stoneMoves.Contains(adjacentPoint))
            {
                stonesInARowCount++;
                return this.TopRightCount(stoneMoves, adjacentPoint, stonesInARowCount);
            }

            return stonesInARowCount;
        }

        /// <inheritdoc />
        public int BottomLeftCount(List<Point> stoneMoves, Point point, int stonesInARowCount)
        {
            if (point.X == 0 || point.Y == 14)
            {
                return stonesInARowCount;
            }

            var adjacentPoint = Board.BoardPoints[point.X - 1, point.Y + 1];

            if (stoneMoves.Contains(adjacentPoint))
            {
                stonesInARowCount++;
                return this.BottomLeftCount(stoneMoves, adjacentPoint, stonesInARowCount);
            }

            return stonesInARowCount;
        }
    }
}
