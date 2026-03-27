using WoodBlockClassic.Core.Models;

namespace WoodBlockClassic.Core.Logic;

public class GridService
{
    public void PlaceSingleBlock(Grid grid, int x, int y)
    {
        grid.GetCell(x, y).IsOccupied = true;
    }
}