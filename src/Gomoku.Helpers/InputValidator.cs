// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputValidator.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the InputValidator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Gomoku.Helpers
{
    /// <summary>
    /// The input validator class.
    /// </summary>
    public class InputValidator
    {
        /// <summary>
        /// Check if the input is valid.
        /// </summary>
        /// <param name="inputLine">
        /// The input line.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsValid(string inputLine)
        {
            var point = inputLine.Split(',');

            if (point.Length != 2)
            {
                return false;
            }

            var validX = int.TryParse(point[0], out _);
            var validY = int.TryParse(point[1], out _);

            return validX && validY;
        }
    }
}
