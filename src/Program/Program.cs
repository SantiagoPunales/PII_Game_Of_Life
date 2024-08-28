using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Crear instancia del lector de archivos
            FileReader lectorArchivo = new FileReader();

            //Leer el archivo de texto para obtener el estado inicial del tablero
            bool[,] estadoInicial = lectorArchivo.LeerArchivo(RUTA_ARCHIVO);

            //Inicializar el tablero con el estado inicial
            Board tablero = new Board(estadoInicial);

            //Crear instancia de la lógica del juego
            Logica logicaJuego = new Logica();

            //Crear instancia de la impresora del tablero
            PrintBoard impresoraTablero = new PrintBoard();

            //Ejecutar el bucle principal del juego
            while (true)
            {
                //Limpiar la consola para mostrar el nuevo estado del tablero
                Console.Clear();

                //Imprimir el tablero actual
                impresoraTablero.Imprimir(tablero);

                //Calcular la siguiente generación del tablero
                logicaJuego.ActualizarTablero(tablero);

                //Esperar un poco antes de la siguiente generación para visualizar el cambio
                Thread.Sleep(300);
            }
        }
    }
}
