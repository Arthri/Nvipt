using Terraria;
using Terraria.ID;
using Nvipt.OTAPI.Extensions;
using Nvipt.Core;

namespace Nvipt.OTAPI
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
                NetMessage.SendData(MessageID.WorldData, player.whoAmI);
            }

            var i = 0;

            ApplySlots(player.inventory, inventory.MainInventory);
            ApplySlots(player.armor, inventory.Equipment);
            ApplySlots(player.dye, inventory.Dye);
            ApplySlots(player.miscEquips, inventory.MiscEquips);
            ApplySlots(player.miscDyes, inventory.MiscDyes);
            ApplySlots(player.bank.item, inventory.PiggyBank);
            ApplySlots(player.bank2.item, inventory.Safe);
            ApplySlot(ref player.trashItem, inventory.TrashItem);
            ApplySlots(player.bank3.item, inventory.DefendersForge);
            ApplySlots(player.bank4.item, inventory.VoidVault);

            if (!wasSSCEnabled && toggleSSC)
            {
                Main.ServerSideCharacter = false;
                NetMessage.SendData(MessageID.WorldData, player.whoAmI);
            }

            void ApplySlots(Item[] items, BasicItem[] newItems)
            {
                var length = i + items.Length;
                for (var j = 0; i < length; i++, j++)
                {
                    if (items[j] == null)
                    {
                        continue;
                    }

                    ApplySlot(ref items[j], newItems[i]);
                }
            }

            bool ApplySlot(ref Item oldItem, BasicItem newItem)
            {
                if (oldItem.IsEqual(newItem))
                {
                    oldItem.SetDefaults(newItem.ID);
                    oldItem.stack = newItem.Stack;
                    oldItem.prefix = newItem.Prefix;
                    NetMessage.SendData(
                        MessageID.SyncEquipment,
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
