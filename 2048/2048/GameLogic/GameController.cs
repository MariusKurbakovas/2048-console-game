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

        private void addRandomValue()
        {
            var rowToPut = random.Next(AppConstants.AppConfig.BoardSize);
            var columnToPut = random.Next(AppConstants.AppConfig.BoardSize);
            if (gameBoard.board[rowToPut, columnToPut] == 0)
            {
                gameBoard.board[rowToPut, columnToPut] = getIntWithRandomProb();
            }
            else
            {
                addRandomValue();
            }
        }

        public void MoveAction(Directions direction)
        {
            var oldBoard = gameBoard.DeepCopy();
            switch (direction)
            {
                case Directions.Right:
                    HorizontalRigthShift();
                    break;
                case Directions.Left:
                    HorizontalLeftShift();
                    break;
                case Directions.Down:
                    VerticalDownShift();
                    break;
                case Directions.Up:
                    VerticalUpShift();
                    break;
                default:
                    return;
            }
            //TODO: no need to check changes each time, the shift method can return true/false based on changes
            if (gameBoard.AreThereChanges(oldBoard))
            {
                addRandomValue();
            }
        }

        //TODO: 4 methods can be overwritten as one or two
        private void VerticalUpShift()
        {
            var board = gameBoard.board;
            for (int j = 0; j < AppConstants.AppConfig.BoardSize; j++)
            {
                for (int i = 0; i < AppConstants.AppConfig.BoardSize - 1; i++)
                {
                    if (board[i, j] == 0)
                    {
                        for (int n = i + 1; n < AppConstants.AppConfig.BoardSize; n++)
                        {
                            if (board[n, j] != 0)
                            {
                                board[i, j] = board[n, j];
                                board[n, j] = 0;
                                break;
                            }
                        }
                    }
                    for (int n = i + 1; n < AppConstants.AppConfig.BoardSize; n++)
                    {
                        if (board[n, j] != 0)
                        {
                            if (board[i, j] == board[n, j])
                            {
                                board[n, j] = 0;
                                board[i, j] *= 2;
                                break;
                            }
                            else
                            {
                                if (i + 1 != n)
                                {
                                    board[i + 1, j] = board[n, j];
                                    board[n, j] = 0;
                                    break;
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void VerticalDownShift()
        {
            var board = gameBoard.board;
            for (int j = 0; j < AppConstants.AppConfig.BoardSize; j++)
            {
                for (int i = AppConstants.AppConfig.BoardSize - 1; i > 0; i--)
                {
                    if (board[i, j] == 0)
                    {
                        for (int n = i - 1; n >= 0; n--)
                        {
                            if (board[n, j] != 0)
                            {
                                board[i, j] = board[n, j];
                                board[n, j] = 0;
                                break;
                            }
                        }
                    }
                    for (int n = i - 1; n >= 0; n--)
                    {
                        if (board[n, j] != 0)
                        {
                            if (board[i, j] == board[n, j])
                            {
                                board[n, j] = 0;
                                board[i, j] *= 2;
                                break;
                            }
                            else
                            {
                                if (i - 1 != n)
                                {
                                    board[i - 1, j] = board[n, j];
                                    board[n, j] = 0;
                                    break;
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void HorizontalRigthShift()
        {
            var board = gameBoard.board;
            for (int i = 0; i < AppConstants.AppConfig.BoardSize; i++)
            {
                for (int j = AppConstants.AppConfig.BoardSize - 1; j >= 0; j--)
                {
                    if (board[i, j] == 0)
                    {
                        for (int n = j - 1; n >= 0; n--)
                        {
                            if (board[i, n] != 0)
                            {
                                board[i, j] = board[i, n];
                                board[i, n] = 0;
                                break;
                            }
                        }
                    }
                    for (int n = j - 1; n >= 0; n--)
                    {
                        if (board[i, n] != 0)
                        {
                            if (board[i, j] == board[i, n])
                            {
                                board[i, n] = 0;
                                board[i, j] *= 2;
                                break;
                            }
                            else
                            {
                                if (j - 1 != n)
                                {
                                    board[i, j - 1] = board[i, n];
                                    board[i, n] = 0;
                                    break;
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void HorizontalLeftShift()
        {
            var board = gameBoard.board;
            for (int i = 0; i < AppConstants.AppConfig.BoardSize; i++)
            {
                for (int j = 0; j < AppConstants.AppConfig.BoardSize - 1; j++)
                {
                    if (board[i, j] == 0)
                    {
                        for (int n = j + 1; n < AppConstants.AppConfig.BoardSize; n++)
                        {
                            if (board[i, n] != 0)
                            {
                                board[i, j] = board[i, n];
                                board[i, n] = 0;
                                break;
                            }
                        }
                    }
                    for (int n = j + 1; n < AppConstants.AppConfig.BoardSize; n++)
                    {
                        if (board[i, n] != 0)
                        {
                            if (board[i, j] == board[i, n])
                            {
                                board[i, n] = 0;
                                board[i, j] *= 2;
                                break;
                            }
                            else
                            {
                                if (j + 1 != n)
                                {
                                    board[i, j + 1] = board[i, n];
                                    board[i, n] = 0;
                                    break;
                                }
                                break;
                            }
                        }
                    }
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
