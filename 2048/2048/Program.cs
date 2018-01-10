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
            OutputGame.ConsoleOutputGame(game.gameBoard);
            var userInput = Console.ReadKey();
            switch (userInput.Key){
                case ConsoleKey.UpArrow:
                    Console.ReadKey();
                    break;
                default:
                    return;
            }
        }
    }
}
