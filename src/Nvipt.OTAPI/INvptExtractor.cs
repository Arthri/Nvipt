using Nvipt.Core;
using Terraria;

namespace Nvipt.OTAPI
{
    public interface INvptExtractor
    {
        Inventory GetInventory(Player player);
    }
}
