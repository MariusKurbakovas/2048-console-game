using System;
using System.Collections.Generic;
using System.Linq;
using _2048.Model;

namespace _2048.GameLogic
{
    public class GameController
    {
        public GameBoard gameBoard = new GameBoard();
        private Random random = new Random();

        public GameController()
        {
            initStartValues(AppConstants.AppConfig.StartingValuesCount);
        }

        private void initStartValues(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var rowToPut = random.Next(AppConstants.AppConfig.BoardSize);
                var columnToPut = random.Next(AppConstants.AppConfig.BoardSize);
                if (gameBoard.board[rowToPut, columnToPut] == 0)
                {
                    gameBoard.board[rowToPut, columnToPut] = getIntWithRandomProb();
                }
                else
                {
                    i--;
                }
            }
        }

        //TODO: not flexible, fix this
        private int getIntWithRandomProb()
        {
            if (random.NextDouble() >= 0.7)
            {
                return 4;
            }
            else
            {
                return 2;
            }
        }
    }
}
