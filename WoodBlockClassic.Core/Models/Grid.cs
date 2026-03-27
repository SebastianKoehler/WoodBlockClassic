namespace WoodBlockClassic.Core.Models;

public class Grid
{
    private readonly Cell[,]  _cells;
    
    public int Width { get; }
    public int Height { get; }
    
    public Grid(int width, int height)
    {
        Width = width;
        Height = height;
        
        _cells = new Cell[width, height];

        InitializeGrid();
    }

    private void InitializeGrid()
    {
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                _cells[x, y] = new Cell();
            }
        }
    }

    public Cell GetCell(int x, int y)
    {
        return _cells[x, y];
    }
}