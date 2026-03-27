using WoodBlockClassic.Core.Models;

namespace WoodBlockClassic.Core.Logic;

public class PlacementValidator
{
    public bool CanPlaceSingleBlock(Grid grid, int x, int y)
    {
        if (x < 0 || y < 0 || x > grid.Width || y >= grid.Height)
            return false;
        
        return !grid.GetCell(x, y).IsOccupied;
    }
}