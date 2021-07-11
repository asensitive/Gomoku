// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStonesInARowService.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the IStonesInARowService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Gomoku.Application.Contracts
{
    using System.Collections.Generic;
    using System.Drawing;

    /// <summary>
    /// The StonesInARowService interface.
    /// </summary>
    public interface IStonesInARowService
    {
        /// <summary>
        /// Get left side stones in a row count.
        /// </summary>
        /// <param name="stoneMoves">
        /// The stone moves.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <param name="stonesInARowCount">
        /// The stones in a row count.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int LeftCount(List<Point> stoneMoves, Point point, int stonesInARowCount);

        /// <summary>
        /// Get right side stones in a row count.
        /// </summary>
        /// <param name="stoneMoves">
        /// The stone moves.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <param name="stonesInARowCount">
        /// The stones in a row count.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int RightCount(List<Point> stoneMoves, Point point, int stonesInARowCount);

        /// <summary>
        /// Get top side stones in a row count.
        /// </summary>
        /// <param name="stoneMoves">
        /// The stone moves.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <param name="stonesInARowCount">
        /// The stones in a row count.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int TopCount(List<Point> stoneMoves, Point point, int stonesInARowCount);

        /// <summary>
        /// Get bottom side stones in a row count.
        /// </summary>
        /// <param name="stoneMoves">
        /// The stone moves.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <param name="stonesInARowCount">
        /// The stones in a row count.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int BottomCount(List<Point> stoneMoves, Point point, int stonesInARowCount);

        /// <summary>
        /// Get top left side stones in a row count.
        /// </summary>
        /// <param name="stoneMoves">
        /// The stone moves.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <param name="stonesInARowCount">
        /// The stones in a row count.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int TopLeftCount(List<Point> stoneMoves, Point point, int stonesInARowCount);

        /// <summary>
        /// Get bottom right side stones in a row count.
        /// </summary>
        /// <param name="stoneMoves">
        /// The stone moves.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <param name="stonesInARowCount">
        /// The stones in a row count.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int BottomRightCount(List<Point> stoneMoves, Point point, int stonesInARowCount);

        /// <summary>
        /// Get top right side stones in a row count.
        /// </summary>
        /// <param name="stoneMoves">
        /// The stone moves.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <param name="stonesInARowCount">
        /// The stones in a row count.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int TopRightCount(List<Point> stoneMoves, Point point, int stonesInARowCount);

        /// <summary>
        /// Get bottom left side stones in a row count.
        /// </summary>
        /// <param name="stoneMoves">
        /// The stone moves.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <param name="stonesInARowCount">
        /// The stones in a row count.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int BottomLeftCount(List<Point> stoneMoves, Point point, int stonesInARowCount);
    }
}