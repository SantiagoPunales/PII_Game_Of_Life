/*************************************************************/
/**** Esto generaría una responsabilidad de cambio adicio-****/
/**** nal si se encontrara en Board, ya que si por ejem-  ****/
/**** plo, alguien quisiera ponerle una interfaz al juego,****/
/**** no podría por este código plantado en el Board, por ****/
/**** lo que lo separamos.                                ****/
/*************************************************************/

using System.Text;
using System;
namespace Ucu.Poo.GameOfLife

{
    public class PrintBoard
    {
        public void Imprimir(Board board)
        {
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < board.Height; y++)
            {
                for (int x = 0; x < board.Width; x++)
                {
                    if (board.Cells[x, y].IsAlive)
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
        }
    }
}