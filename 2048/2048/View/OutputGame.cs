using System;
using _2048.Extensions;
using _2048.Model;

namespace _2048.View
{
    public class OutputGame
    {
        private static void ConsoleOutputHorizontalLines(int dashCount)
        {
            for (int i = 0; i < dashCount; i++)
            {
                Console.Write('-');
            }
            Console.Write('\n');
        }

        public static void ConsoleOutputGame(GameBoard gameBoard)
        {
            ConsoleOutputHorizontalLines(AppConstants.AppConfig.BoardSize * 6 + 1);
            for (int i = 0; i < AppConstants.AppConfig.BoardSize; i++)
            {
                for (int j = 0; j < AppConstants.AppConfig.BoardSize; j++)
                {
                    Console.Write("|");
                    if (gameBoard.board[i, j] != 0)
                    {
                        Console.Write(gameBoard.board[i, j].ToString().CenterPad(AppConstants.AppConfig.BoardIntPadLength));
                    }
                    else
                    {
                        Console.Write("".CenterPad(AppConstants.AppConfig.BoardIntPadLength));
                    }
                }
                Console.Write("|");
                Console.Write('\n');
            }
            ConsoleOutputHorizontalLines(AppConstants.AppConfig.BoardSize * 6 + 1);
        }
    }
}
