// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Game.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the Game type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Gomoku.Domain
{
    using System.Collections.Generic;
    using System.Drawing;

    using Gomoku.Domain.Shared;

    /// <summary>
    /// The game class.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        public Game()
        {
            this.BlackStonePositions = new List<Point>();
            this.WhiteStonePositions = new List<Point>();
            this.PlayerTurn = StoneColor.Black;
        }

        /// <summary>
        /// Gets or sets the player turn based on stone color.
        /// </summary>
        public StoneColor PlayerTurn { get; set; }

        /// <summary>
        /// Gets or sets the black stone player moves.
        /// </summary>
        public List<Point> BlackStonePositions { get; set; }

        /// <summary>
        /// Gets or sets the white stone player moves.
        /// </summary>
        public List<Point> WhiteStonePositions { get; set; }
    }
}
