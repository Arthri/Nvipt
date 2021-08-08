using Nvipt.Core;
using Terraria;

namespace Nvipt.OTAPI
{
    public interface INvptApplier
    {
        void Apply(Inventory inventory, Player player);
    }
}
