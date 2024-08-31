/*************************************************************/
/**** Este fue separado para definir si la célula está    ****/
/**** viva, hecho sobre todo por lo importante que es     ****/
/**** esto, ya que si lo borramos sin querer de otro      ****/
/**** código que si no nos interesa, destruiríamos el     ****/
/**** juego.                                              ****/
/*************************************************************/

namespace Ucu.Poo.GameOfLife
{
    public class Cell
    {
        public bool IsAlive { get; set; }

        public Cell(bool isAlive)
        {
            IsAlive = isAlive;
        }
    }
}