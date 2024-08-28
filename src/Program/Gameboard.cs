public class Logic
{
    public bool[,] CalculateNextGeneration(bool[,] gameBoard)
    {
        int boardWidth = gameBoard.GetLength(0);
        int boardHeight = gameBoard.GetLength(1);
        bool[,] cloneboard = new bool[boardWidth, boardHeight];

        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;

                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j])
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (gameBoard[x, y])
                {
                    aliveNeighbors--; // Restamos el conteo de la propia célula
                }

                // Aplicamos las reglas del juego
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

        return cloneboard; // Retorna la nueva generación del tablero
    }
}