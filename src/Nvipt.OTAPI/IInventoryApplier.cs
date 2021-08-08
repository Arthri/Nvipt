using Nvipt.Core;
using Terraria;

namespace Nvipt.OTAPI
{
    public interface IInventoryApplier
    {
        void Apply(Inventory inventory, Player player);
    }
}
