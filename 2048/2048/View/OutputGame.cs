using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2048.Model;

namespace _2048.View
{
    public class OutputGame
    {
        public static void ConsoleOutputGame(GameBoard gameBoard)
        {
            Console.WriteLine("----------------");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("|");
                    Console.Write(gameBoard.board[i, j]);
                }
                Console.Write("|");
                Console.Write('\n');
            }
            Console.WriteLine("----------------");
        }
    }
}
