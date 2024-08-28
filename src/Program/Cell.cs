namespace Ucu.Poo.GameOfLife;

public class Cell
{
    // Método que calcula la siguiente generación del tablero en el Juego de la Vida
    public bool[,] CalcularNueG(bool[,] gameBoard)
    {
        // Obtiene el ancho y alto del tablero
        int boardWidth = gameBoard.GetLength(0);
        int boardHeight = gameBoard.GetLength(1);
        
        // Crea una nueva matriz para almacenar la próxima generación
        bool[,] cloneboard = new bool[boardWidth, boardHeight];

        // Itera sobre cada célula del tablero
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0; // Contador de vecinos vivos

                // Recorre los vecinos alrededor de la célula actual
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        // Verifica si el vecino está dentro de los límites del tablero y si está vivo
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j])
                        {
                            aliveNeighbors++; // Incrementa el contador de vecinos vivos
                        }
                    }
                }

                if (gameBoard[x, y])
                {
                    aliveNeighbors--; // Restamos el conteo de la propia célula si está viva
                }

                // Aplica las reglas del juego de la vida
                if (gameBoard[x, y] && aliveNeighbors < 2)
                {
                    // Menos de 2 vecinos vivos: la célula muere por soledad
                    cloneboard[x, y] = false;
                }
                else if (gameBoard[x, y] && aliveNeighbors > 3)
                {
                    // Más de 3 vecinos vivos: la célula muere por sobrepoblación
                    cloneboard[x, y] = false;
                }
                else if (!gameBoard[x, y] && aliveNeighbors == 3)
                {
                    // Exactamente 3 vecinos vivos: una célula muerta nace por reproducción
                    cloneboard[x, y] = true;
                }
                else
                {
                    // La célula mantiene su estado actual
                    cloneboard[x, y] = gameBoard[x, y];
                }
            }
        }

        // Retorna la nueva generación del tablero
        return cloneboard;
    }
}