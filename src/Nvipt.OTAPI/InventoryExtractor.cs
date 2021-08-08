using Nvipt.Core;
using Nvipt.OTAPI.Extensions;
using Terraria;

namespace Nvipt.OTAPI
{
    public class InventoryExtractor : IInventoryExtractor
    {
        private static readonly int _slotsCount = 260;

        public InventoryExtractor()
        {
        }

        public virtual Inventory GetInventory(Player player)
        {
            var items = new BasicItem[_slotsCount];

            var i = 0;

            Copy(player.inventory);
            Copy(player.armor);
            Copy(player.dye);
            Copy(player.miscEquips);
            Copy(player.miscDyes);
            Copy(player.bank.item);
            Copy(player.bank2.item);
            items[i++] = player.trashItem.ToBasicItem();
            Copy(player.bank3.item);
            Copy(player.bank4.item);

            void Copy(Item[] tItems)
            {
                foreach (var item in tItems)
                {
                    items[i++] = item.ToBasicItem();
                }
            }

            return new Inventory
            {
                Items = items
            };
        }
    }
}
