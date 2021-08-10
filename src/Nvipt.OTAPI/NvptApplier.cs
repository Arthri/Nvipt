using Terraria;
using Terraria.ID;
using Nvipt.OTAPI.Extensions;
using Nvipt.Core;

namespace Nvipt.OTAPI
{
    /// <summary>
    /// Provides an implementation of <see cref="INvptApplier"/> through SSC.
    /// </summary>
    public class NvptApplier : INvptApplier
    {
        /// <inheritdoc />
        void INvptApplier.Apply(Inventory inventory, Player player)
        {
            Apply(inventory, player, true);
        }

        /// <inheritdoc cref="INvptApplier.Apply(Inventory, Player)"/>
        /// <param name="toggleSSC">If true, then SSC will be turned on if it isn't already. SSC will be turned off after the operation.</param>
        // It's inherited
#pragma warning disable CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
        public void Apply(Inventory inventory, Player player, bool toggleSSC = true)
#pragma warning restore CS1573 // Parameter has no matching param tag in the XML comment (but other parameters do)
        {
            var wasSSCEnabled = Main.ServerSideCharacter;

            if (!wasSSCEnabled && toggleSSC)
            {
                Main.ServerSideCharacter = true;
                NetMessage.SendData(MessageID.WorldData, player.whoAmI);
            }

            var i = 0;

            ApplySlots(player.inventory, inventory.Backpack);
            ApplySlots(player.armor, inventory.Equipment);
            ApplySlots(player.dye, inventory.Dyes);
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
