using Terraria;

namespace Nvipt.Helpers
{
    public class InventoryApplier : IInventoryApplier
    {
        void IInventoryApplier.Apply(Inventory inventory, Player player)
        {
            Apply(inventory, player, true);
        }

        public void Apply(Inventory inventory, Player player, bool toggleSSC = true)
        {
            var wasSSCEnabled = Main.ServerSideCharacter;

            if (!wasSSCEnabled && toggleSSC)
            {
                Main.ServerSideCharacter = true;
                NetMessage.SendData((int)PacketTypes.WorldInfo, player.whoAmI);
            }

            var i = 0;

            ApplySlots(player.inventory);
            ApplySlots(player.armor);
            ApplySlots(player.dye);
            ApplySlots(player.miscEquips);
            ApplySlots(player.miscDyes);
            ApplySlots(player.bank.item);
            ApplySlots(player.bank2.item);
            ApplySlot(ref player.trashItem, inventory.Items[i++]);
            ApplySlots(player.bank3.item);
            ApplySlots(player.bank4.item);

            if (!wasSSCEnabled && toggleSSC)
            {
                Main.ServerSideCharacter = false;
                NetMessage.SendData((int)PacketTypes.WorldInfo, player.whoAmI);
            }

            void ApplySlots(Item[] items)
            {
                var length = i + items.Length;
                for (var j = 0; i < length; i++, j++)
                {
                    if (items[j] == null)
                    {
                        continue;
                    }

                    ApplySlot(ref items[j], inventory.Items[i]);
                }
            }

            bool ApplySlot(ref Item oldItem, BasicItem newItem)
            {
                if (oldItem != newItem)
                {
                    oldItem.SetDefaults(newItem.ID);
                    oldItem.stack = newItem.Stack;
                    oldItem.prefix = newItem.Prefix;
                    NetMessage.SendData(
                        (int)PacketTypes.PlayerSlot,
                        number: player.whoAmI,
                        number2: i,
                        number3: newItem.Prefix);
                    return true;
                }
                return false;
            }
        }
    }
}
