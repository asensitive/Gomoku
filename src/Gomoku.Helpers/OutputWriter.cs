// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OutputWriter.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   The output writer class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Gomoku.Helpers
{
    using System;

    using Gomoku.Domain;

    /// <summary>
    /// The output writer class.
    /// </summary>
    public class OutputWriter
    {
        /// <summary>
        /// Display the game board.
        /// </summary>
        public static void DisplayBoard()
        {
            for (var j = 0; j < 15; j++)
            {
                for (var i = 0; i < 15; i++)
                {
                    Console.Write(
                        Board.BoardPoints[i, j].Y > 9
                            ? $"[{Board.BoardPoints[i, j].X}, {Board.BoardPoints[i, j].Y}]"
                            : $"[{Board.BoardPoints[i, j].X},  {Board.BoardPoints[i, j].Y}]");
                }

                Console.Write("\n");
            }
        }
    }
}
