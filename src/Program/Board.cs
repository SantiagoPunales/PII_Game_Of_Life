namespace Ucu.Poo.GameOfLife
{
    public class Board
    {
        public Cell[,] Cells { get; set; }
        public int Width => Cells.GetLength(0);
        public int Height => Cells.GetLength(1);

        public Board(bool[,] initialState)
        {
            int width = initialState.GetLength(0);
            int height = initialState.GetLength(1);
            Cells = new Cell[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Cells[x, y] = new Cell(initialState[x, y]);
                }
            }
        }

        public bool[,] GetBoardState()
        {
            bool[,] state = new bool[Width, Height];
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    state[x, y] = Cells[x, y].IsAlive;
                }
            }
            return state;
        }

        public void SetBoardState(bool[,] state)
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Cells[x, y].IsAlive = state[x, y];
                }
            }
        }
    }
}