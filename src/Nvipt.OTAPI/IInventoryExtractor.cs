using Terraria;

namespace Nvipt.OTAPI
{
    public interface IInventoryExtractor
    {
        IItemConverter ItemConverter { get; }
        Inventory GetInventory(Player player);
    }
}
