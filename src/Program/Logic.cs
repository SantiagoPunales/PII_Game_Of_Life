

namespace Ucu.Poo.GameOfLife
{
    public class Logic
    {
        public void ActualizarTablero(Board board)
        {
            bool[,] gameBoard = board.GetBoardState();
            bool[,] cloneboard = new bool[board.Width, board.Height];

            for (int x = 0; x < board.Width; x++)
            {
                for (int y = 0; y < board.Height; y++)
                {
                    int aliveNeighbors = 0;

                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (i >= 0 && i < board.Width && j >= 0 && j < board.Height && gameBoard[i, j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }

                    if (gameBoard[x, y])
                    {
                        aliveNeighbors--;
                    }

                    if (gameBoard[x, y] && aliveNeighbors < 2)
                    {
                        cloneboard[x, y] = false;
                    }
                    else if (gameBoard[x, y] && aliveNeighbors > 3)
                    {
                        cloneboard[x, y] = false;
                    }
                    else if (!gameBoard[x, y] && aliveNeighbors == 3)
                    {
                        cloneboard[x, y] = true;
                    }
                    else
                    {
                        cloneboard[x, y] = gameBoard[x, y];
                    }
                }
            }
            board.SetBoardState(cloneboard);
        }
    }
}