using Nvipt.Core;
using Terraria;

namespace Nvipt.OTAPI
{
    /// <summary>
    /// Defines mechanisms to apply Nvpts to players.
    /// </summary>
    public interface INvptApplier
    {
        /// <summary>
        /// Applies <paramref name="inventory"/> to <paramref name="player"/>.
        /// </summary>
        /// <param name="inventory">The inventory to apply.</param>
        /// <param name="player">The player to apply to.</param>
        void Apply(Inventory inventory, Player player);
    }
}
