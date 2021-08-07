using Terraria;

namespace Nvipt.Helpers
{
    public interface IInventoryApplier
    {
        void Apply(Inventory inventory, Player player);
    }
}
