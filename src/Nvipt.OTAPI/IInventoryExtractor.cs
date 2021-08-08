using Terraria;

namespace Nvipt.OTAPI
{
    public interface IInventoryExtractor
    {
        Inventory GetInventory(Player player);
    }
}
