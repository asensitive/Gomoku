// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputReader.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the InputReader type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Gomoku.Helpers
{
    using System;
    using System.Drawing;

    /// <summary>
    /// The input reader class.
    /// </summary>
    public class InputReader
    {
        /// <summary>
        /// The read point from the line entered on console.
        /// </summary>
        /// <param name="inputLine">
        /// The input line.
        /// </param>
        /// <returns>
        /// The <see cref="Point"/>.
        /// </returns>
        public static Point ReadPoint(string inputLine)
        {
            var point = inputLine.Split(',');

            return new Point(Convert.ToInt16(point[0]), Convert.ToInt16(point[1]));
        }
    }
}
