namespace _2048.Model
{
    public class GameBoard
    {
        public int[,] board = new int[AppConstants.AppConfig.BoardSize, AppConstants.AppConfig.BoardSize];

        public int[,] DeepCopy()
        {
            int[,] newBoard = new int[AppConstants.AppConfig.BoardSize, AppConstants.AppConfig.BoardSize];
            for (int i = 0; i < AppConstants.AppConfig.BoardSize; i++)
            {
                for (int j = 0; j < AppConstants.AppConfig.BoardSize; j++)
                {
                    newBoard[i, j] = board[i, j];
                }
            }
            return newBoard;
        }

        public bool AreThereChanges(int[,] otherBoard)
        {
            for (int i = 0; i < AppConstants.AppConfig.BoardSize; i++)
            {
                for (int j = 0; j < AppConstants.AppConfig.BoardSize; j++)
                {
                    if (board[i, j] != otherBoard[i, j]) return true;
                }
            }
            return false;
        }

        public bool BoardFull()
        {
            foreach(var element in board)
            {
                if (element == 0) return false;
            }
            return true;
        }
    }
}
