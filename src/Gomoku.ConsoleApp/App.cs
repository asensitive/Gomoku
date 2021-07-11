// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.cs" company="HP">
//   HP
// </copyright>
// <summary>
//   Defines the App type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Gomoku.ConsoleApp
{
    using System;

    using Gomoku.Application;
    using Gomoku.Application.Contracts;
    using Gomoku.Domain;
    using Gomoku.Domain.Shared;
    using Gomoku.Helpers;

    /// <summary>
    /// The app.
    /// </summary>
    public static class App
    {
        /// <summary>
        /// The run method.
        /// </summary>
        public static void Run()
        {
            var game = new Game();
            IFiveInARowService fiveInARowService = new FiveInARowService();

            OutputWriter.DisplayBoard();

            do
            {
                Console.WriteLine("______________________________________________________________________________________________________________");
                Console.WriteLine("{0} stone player enter points X,Y (example 5,5):", game.PlayerTurn);

                var inputLine = Console.ReadLine();

                if (inputLine == "stop")
                {
                    break;
                }

                if (!InputValidator.IsValid(inputLine))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                var inputPoint = InputReader.ReadPoint(inputLine);

                if (!Board.ValidPositions.Contains(inputPoint))
                {
                    Console.WriteLine("Invalid move!");
                    continue;
                }

                if (game.BlackStonePositions.Contains(inputPoint) || game.WhiteStonePositions.Contains(inputPoint))
                {
                    Console.WriteLine("Already taken!");
                    continue;
                }

                if (game.PlayerTurn == StoneColor.Black)
                {
                    game.BlackStonePositions.Add(inputPoint);

                    if (game.BlackStonePositions.Count >= 5)
                    {
                        if (fiveInARowService.CheckFiveInARow(game.BlackStonePositions, inputPoint))
                        {
                            Console.WriteLine("**************************************************************************************************************");
                            Console.WriteLine("Black Stone Player Win ! *************************************************************************************");
                            Console.WriteLine("**************************************************************************************************************");
                            game.BlackStonePositions.Clear();
                            game.WhiteStonePositions.Clear();

                            Console.WriteLine("Play again? y/n");
                            var playAgain = Console.ReadLine();

                            if (playAgain == "y")
                            {
                                continue;
                            }

                            break;
                        }
                    }

                    game.PlayerTurn = StoneColor.White;
                }
                else
                {
                    game.WhiteStonePositions.Add(inputPoint);

                    if (game.WhiteStonePositions.Count >= 5)
                    {
                        if (fiveInARowService.CheckFiveInARow(game.WhiteStonePositions, inputPoint))
                        {
                            Console.WriteLine("**************************************************************************************************************");
                            Console.WriteLine("White Stone Player Win ! *************************************************************************************");
                            Console.WriteLine("**************************************************************************************************************");
                            game.WhiteStonePositions.Clear();
                            game.BlackStonePositions.Clear();

                            Console.WriteLine("Play again? y/n");
                            var playAgain = Console.ReadLine();

                            if (playAgain == "y")
                            {
                                continue;
                            }

                            break;
                        }
                    }

                    game.PlayerTurn = StoneColor.Black;
                }
            }
            while (true);
        }
    }
}
