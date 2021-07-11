// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFiveInARowService.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the IFiveInARowService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Gomoku.Application.Contracts
{
    using System.Collections.Generic;
    using System.Drawing;

    /// <summary>
    /// The FiveInARowService interface.
    /// </summary>
    public interface IFiveInARowService
    {
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
        bool CheckFiveInARow(List<Point> stoneMoves, Point point);

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
        bool CheckHorizontalFiveInARow(List<Point> stoneMoves, Point point);

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
        bool CheckVerticalFiveInARow(List<Point> stoneMoves, Point point);

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
        bool CheckBackwardDiagonalFiveInARow(List<Point> stoneMoves, Point point);

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
        bool CheckForwardDiagonalFiveInARow(List<Point> stoneMoves, Point point);
    }
}