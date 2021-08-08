namespace Nvipt.Core
{
    /// <summary>
    /// Represents a player's inventory.
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// Represents the size of <see cref="MainInventory"/>.
        /// </summary>
        public static readonly int MainInventorySize = 59;

        /// <summary>
        /// Represents the amount of armor slots.
        /// </summary>
        public static readonly int ArmorSize = 3;

        /// <summary>
        /// Represents the amount of accessory slots.
        /// </summary>
        public static readonly int AccessorySize = 7;

        /// <summary>
        /// Represents the size of <see cref="Equipment"/>.
        /// </summary>
        public static readonly int EquipmentSize = ArmorSize + AccessorySize + 10;

        /// <summary>
        /// Represents the size of <see cref="Dye"/>.
        /// </summary>
        public static readonly int DyeSize = 10;

        /// <summary>
        /// Represents the size of <see cref="MiscEquips"/>.
        /// </summary>
        public static readonly int MiscEquipsSize = 5;

        /// <summary>
        /// Represents the size of <see cref="MiscDyes"/>.
        /// </summary>
        public static readonly int MiscDyesSize = 5;

        /// <summary>
        /// Represents the size of <see cref="PiggyBank"/>.
        /// </summary>
        public static readonly int PiggyBankSize = 40;

        /// <summary>
        /// Represents the size of <see cref="Safe"/>.
        /// </summary>
        public static readonly int SafeSize = 40;

        /// <summary>
        /// Represents the size of <see cref="DefendersForge"/>.
        /// </summary>
        public static readonly int DefendersForgeSize = 40;

        /// <summary>
        /// Represents the size of <see cref="VoidVault"/>.
        /// </summary>
        public static readonly int VoidVaultSize = 40;

        /// <summary>
        /// Represents the total size of an inventory.
        /// </summary>
        public static readonly int InventorySize = 
            MainInventorySize
          + EquipmentSize
          + DyeSize
          + MiscEquipsSize
          + MiscDyesSize
          + PiggyBankSize
          + SafeSize
          + 1
          + DefendersForgeSize
          + VoidVaultSize;

        /// <summary>
        /// Represents the main inventory including the hot bar, coins, ammo and mouse item.
        /// </summary>
        public BasicItem[] MainInventory { get; }

        /// <summary>
        /// Represents the armor slots including the armor, accessories, and vanity.
        /// </summary>
        public BasicItem[] Equipment { get; }

        /// <summary>
        /// Represents the dye slots.
        /// </summary>
        public BasicItem[] Dye { get; }

        /// <summary>
        /// Represents the miscellaneous equip slots, including the pet, light pet, mount, minecart, and hook.
        /// </summary>
        public BasicItem[] MiscEquips { get; }

        /// <summary>
        /// Represents the miscellaneous dye slots.
        /// </summary>
        public BasicItem[] MiscDyes { get; }

        /// <summary>
        /// Represents the piggy bank slots.
        /// </summary>
        public BasicItem[] PiggyBank { get; }

        /// <summary>
        /// Represents the safe(storage) slots.
        /// </summary>
        public BasicItem[] Safe { get; }

        /// <summary>
        /// Represents the trash item.
        /// </summary>
        public BasicItem TrashItem { get; }

        /// <summary>
        /// Represents the defender's forge slots.
        /// </summary>
        public BasicItem[] DefendersForge { get; }

        /// <summary>
        /// Represents the void vault slots.
        /// </summary>
        public BasicItem[] VoidVault { get; }
    }
}