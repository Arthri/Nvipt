using Nvipt.Core;
using Terraria;

namespace Nvipt.OTAPI
{
    /// <summary>
    /// Defines mechanisms to extracts Nvpt data from players.
    /// </summary>
    public interface INvptExtractor
    {
        /// <summary>
        /// Returns the inventory of <paramref name="player"/> as <see cref="Inventory"/>.
        /// </summary>
        /// <param name="player">The player to extract the inventory from.</param>
        /// <returns>The extracted inventory.</returns>
        Inventory GetInventory(Player player);
    }
}
