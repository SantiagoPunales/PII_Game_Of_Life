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