using Terraria;

namespace Nvipt.Helpers
{
    public interface IInventoryExtractor
    {
        IItemConverter ItemConverter { get; }
        Inventory GetInventory(Player player);
    }
}
