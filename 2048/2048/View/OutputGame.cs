using System;
using _2048.Extensions;
using _2048.Model;

namespace _2048.View
{
    public class OutputGame
    {
        public static void ConsoleOutputGame(GameBoard gameBoard)
        {
            Console.WriteLine("---------------------");
            for (int i = 0; i < AppConstants.AppConfig.BoardSize; i++)
            {
                for (int j = 0; j < AppConstants.AppConfig.BoardSize; j++)
                {
                    Console.Write("|");
                    Console.Write(gameBoard.board[i, j].ToString().CenterPad(AppConstants.AppConfig.MaxGameBoardIntLength));
                }
                Console.Write("|");
                Console.Write('\n');
            }
            Console.WriteLine("----------------------");
        }
    }
}
