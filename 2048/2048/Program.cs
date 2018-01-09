using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2048.Model;
using _2048.View;

namespace _2048
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputGame.ConsoleOutputGame(new GameBoard());
            Console.ReadKey();
        }
    }
}
