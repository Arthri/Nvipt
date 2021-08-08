using Nvipt.Core;
using Nvipt.OTAPI.Extensions;
using Terraria;

namespace Nvipt.OTAPI
{
    /// <summary>
    /// Default implementation of <see cref="NvptExtractor"/>
    /// </summary>
    public class NvptExtractor : INvptExtractor
    {
        /// <inheritdoc />
        public Inventory GetInventory(Player player)
        {
            return new Inventory(
                player.inventory.ToBasicItem(),
                player.armor.ToBasicItem(),
                player.dye.ToBasicItem(),
                player.miscEquips.ToBasicItem(),
                player.miscDyes.ToBasicItem(),
                player.bank.item.ToBasicItem(),
                player.bank2.item.ToBasicItem(),
                player.bank3.item.ToBasicItem(),
                player.bank4.item.ToBasicItem())
            {
                TrashItem = player.trashItem.ToBasicItem()
            };
        }
    }
}
