using System.IO;  
namespace Ucu.Poo.GameOfLife 
{
    public class FileReader  
    {
        public bool[,] LeerArchivo(string url)  // Método que lee el archivo "board.txt" y devuelve un tablero en forma de matriz de booleanos.
        {
            
            string content = File.ReadAllText(url);  // Lee todo el contenido del archivo como un string.
            string[] contentLines = content.Split('\n');  // Divide el contenido del archivo en líneas separadas por saltos de línea.
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];  // Crea una matriz de booleanos con dimensiones basadas en el número de líneas y la longitud de la primera línea.

            for (int y = 0; y < contentLines.Length; y++)  // Itera a través de cada línea del archivo.
            {
                for (int x = 0; x < contentLines[y].Length; x++)  // Itera a través de cada carácter de la línea actual.
                {
                    if(contentLines[y][x]=='1')  // Verifica si el carácter actual es '1'.
                    {
                        board[x,y]=true;  // Si es '1', establece la celda correspondiente en la matriz como `true`.
                    }
                    // Aquí podrías agregar un `else` para manejar los ceros ('0') si fuera necesario.
                }
            }

            return board;  // Retorna la matriz de booleanos que representa el tablero.
        }    
    }    
}