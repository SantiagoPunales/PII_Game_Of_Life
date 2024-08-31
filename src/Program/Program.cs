using System;
using System.Threading;

namespace Ucu.Poo.GameOfLife;
class Program
{
    static void Main(string[] args)
    {
        FileReader lectorArchivo = new FileReader();
        bool[,] estadoInicial = lectorArchivo.LeerBlocDeNotas("board.txt");
        Board tablero = new Board(estadoInicial);
        Logic logicaJuego = new Logic();
        PrintBoard impresoraTablero = new PrintBoard();
        while (true)
        {
            Console.Clear();
            impresoraTablero.Imprimir(tablero);
            logicaJuego.ActualizarTablero(tablero);
            Thread.Sleep(300);
        }
    }
}