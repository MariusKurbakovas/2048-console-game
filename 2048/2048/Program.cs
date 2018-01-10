using System;
using _2048.GameLogic;
using _2048.Model;
using _2048.View;

namespace _2048
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController game = new GameController();
            while (true)
            {
                Console.Clear();
                OutputGame.ConsoleOutputGame(game.gameBoard);
                var userInput = Console.ReadKey();
                switch (userInput.Key)
                {
                    case ConsoleKey.UpArrow:
                        game.MoveAction(Directions.Up);
                        break;
                    case ConsoleKey.DownArrow:
                        game.MoveAction(Directions.Down);
                        break;
                    case ConsoleKey.LeftArrow:
                        game.MoveAction(Directions.Left);
                        break;
                    case ConsoleKey.RightArrow:
                        game.MoveAction(Directions.Right);
                        break;
                    default:
                        return;
                }
            }
            
        }
    }
}
