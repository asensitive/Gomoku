// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Board.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the Board type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Gomoku.Domain
{
    using System.Collections.Generic;
    using System.Drawing;

    /// <summary>
    /// The board class.
    /// </summary>
    public static class Board
    {
        /// <summary>
        /// The board points constant.
        /// </summary>
        public static Point[,] BoardPoints => CreateBoard();

        /// <summary>
        /// Gets the valid positions.
        /// </summary>
        public static List<Point> ValidPositions { get; private set; }

        /// <summary>
        /// Create board for the game.
        /// </summary>
        /// <returns>
        /// The game board.
        /// </returns>
        private static Point[,] CreateBoard()
        {
            var boardPoints = new Point[15, 15];
            ValidPositions = new List<Point>();

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    boardPoints[j, i].Y = i;
                    boardPoints[j, i].X = j;

                    ValidPositions.Add(new Point(j, i));
                }
            }

            return boardPoints;
        }
    }
}
