using Terraria;

namespace Nvipt.OTAPI
{
    public class InventoryExtractor : IInventoryExtractor
    {
        private static readonly int _slotsCount = 260;

        public IItemConverter ItemConverter { get; }

        public InventoryExtractor()
        {
            ItemConverter = new ItemConverter();
        }

        public InventoryExtractor(IItemConverter itemConverter)
        {
            ItemConverter = itemConverter;
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
            items[i++] = ItemConverter.ToBasicItem(player.trashItem);
            Copy(player.bank3.item);
            Copy(player.bank4.item);

            void Copy(Item[] tItems)
            {
                foreach (var item in tItems)
                {
                    items[i++] = ItemConverter.ToBasicItem(item);
                }
            }

            return new Inventory
            {
                Items = items
            };
        }
    }
}
