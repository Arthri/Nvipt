using System;

namespace Nvipt.Core
{
    /// <summary>
    /// Represents a player's inventory.
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// Represents the size of <see cref="Backpack"/>.
        /// </summary>
        public static readonly int BackpackSize = 59;

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
        /// Represents the size of <see cref="Dyes"/>.
        /// </summary>
        public static readonly int DyesSize = 10;

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
            BackpackSize
          + EquipmentSize
          + DyesSize
          + MiscEquipsSize
          + MiscDyesSize
          + PiggyBankSize
          + SafeSize
          + 1
          + DefendersForgeSize
          + VoidVaultSize;

        /// <summary>
        /// The backing field for <see cref="Backpack"/>.
        /// </summary>
        private BasicItem[] _backpack;

        /// <summary>
        /// Represents the main inventory including the hot bar, coins, ammo and mouse item.
        /// </summary>
        public BasicItem[] Backpack
        {
            get => _backpack;

            set
            {
                if (value.Length != BackpackSize)
                {
                    throw new ArgumentException(nameof(value) + " is incorrectly sized.", nameof(value));
                }

                _backpack = value;
            }
        }

        /// <summary>
        /// The backing field for <see cref="Equipment"/>.
        /// </summary>
        private BasicItem[] _equipment;

        /// <summary>
        /// Represents the armor slots including the armor, accessories, and vanity.
        /// </summary>
        public BasicItem[] Equipment
        {
            get => _equipment;

            set
            {
                if (value.Length != EquipmentSize)
                {
                    throw new ArgumentException(nameof(value) + " is incorrectly sized.", nameof(value));
                }

                _equipment = value;
            }
        }

        /// <summary>
        /// The backing field for <see cref="Dyes"/>.
        /// </summary>
        private BasicItem[] _dyes;

        /// <summary>
        /// Represents the dye slots.
        /// </summary>
        public BasicItem[] Dyes
        {
            get => _dyes;

            set
            {
                if (value.Length != DyesSize)
                {
                    throw new ArgumentException(nameof(value) + " is incorrectly sized.", nameof(value));
                }

                _dyes = value;
            }
        }

        /// <summary>
        /// The backing field for <see cref="MiscEquips"/>.
        /// </summary>
        private BasicItem[] _miscEquips;

        /// <summary>
        /// Represents the miscellaneous equip slots, including the pet, light pet, mount, minecart, and hook.
        /// </summary>
        public BasicItem[] MiscEquips
        {
            get => _miscEquips;

            set
            {
                if (value.Length != MiscEquipsSize)
                {
                    throw new ArgumentException(nameof(value) + " is incorrectly sized.", nameof(value));
                }

                _miscEquips = value;
            }
        }

        /// <summary>
        /// The backing field for <see cref="MiscDyes"/>.
        /// </summary>
        private BasicItem[] _miscDyes;

        /// <summary>
        /// Represents the miscellaneous dye slots.
        /// </summary>
        public BasicItem[] MiscDyes
        {
            get => _miscDyes;

            set
            {
                if (value.Length != MiscDyesSize)
                {
                    throw new ArgumentException(nameof(value) + " is incorrectly sized.", nameof(value));
                }

                _miscDyes = value;
            }
        }

        /// <summary>
        /// The backing field for <see cref="PiggyBank"/>.
        /// </summary>
        private BasicItem[] _piggyBank;

        /// <summary>
        /// Represents the piggy bank slots.
        /// </summary>
        public BasicItem[] PiggyBank
        {
            get => _piggyBank;

            set
            {
                if (value.Length != PiggyBankSize)
                {
                    throw new ArgumentException(nameof(value) + " is incorrectly sized.", nameof(value));
                }

                _piggyBank = value;
            }
        }

        /// <summary>
        /// The backing field for <see cref="Safe"/>.
        /// </summary>
        private BasicItem[] _safe;

        /// <summary>
        /// Represents the safe(storage) slots.
        /// </summary>
        public BasicItem[] Safe
        {
            get => _safe;

            set
            {
                if (value.Length != SafeSize)
                {
                    throw new ArgumentException(nameof(value) + " is incorrectly sized.", nameof(value));
                }

                _safe = value;
            }
        }

        /// <summary>
        /// Represents the trash item.
        /// </summary>
        public BasicItem TrashItem { get; set; }

        /// <summary>
        /// The backing field for <see cref="DefendersForge"/>.
        /// </summary>
        private BasicItem[] _defendersForge;

        /// <summary>
        /// Represents the defender's forge slots.
        /// </summary>
        public BasicItem[] DefendersForge
        {
            get => _defendersForge;

            set
            {
                if (value.Length != DefendersForgeSize)
                {
                    throw new ArgumentException(nameof(value) + " is incorrectly sized.", nameof(value));
                }

                _defendersForge = value;
            }
        }

        /// <summary>
        /// The backing field for <see cref="VoidVault"/>.
        /// </summary>
        private BasicItem[] _voidVault;

        /// <summary>
        /// Represents the void vault slots.
        /// </summary>
        public BasicItem[] VoidVault
        {
            get => _voidVault;

            set
            {
                if (value.Length != VoidVaultSize)
                {
                    throw new ArgumentException(nameof(value) + " is incorrectly sized.", nameof(value));
                }

                _voidVault = value;
            }
        }

        /// <summary>
        /// Initializes an inventory with empty items.
        /// </summary>
        public Inventory()
        {
            _backpack = new BasicItem[BackpackSize];
            _equipment = new BasicItem[EquipmentSize];
            _dyes = new BasicItem[DyesSize];
            _miscEquips = new BasicItem[MiscEquipsSize];
            _miscDyes = new BasicItem[MiscDyesSize];
            _piggyBank = new BasicItem[PiggyBankSize];
            _safe = new BasicItem[SafeSize];
            _defendersForge = new BasicItem[DefendersForgeSize];
            _voidVault = new BasicItem[VoidVaultSize];
        }

        /// <summary>
        /// Initializes an inventory with the specified items.
        /// </summary>
        /// <param name="backpack"><inheritdoc cref="Backpack" path="/summary"/></param>
        /// <param name="equipment"><inheritdoc cref="Equipment" path="/summary"/></param>
        /// <param name="dyes"><inheritdoc cref="Dyes" path="/summary"/></param>
        /// <param name="miscEquips"><inheritdoc cref="MiscEquips" path="/summary"/></param>
        /// <param name="miscDyes"><inheritdoc cref="MiscDyes" path="/summary"/></param>
        /// <param name="piggyBank"><inheritdoc cref="PiggyBank" path="/summary"/></param>
        /// <param name="safe"><inheritdoc cref="Safe" path="/summary"/></param>
        /// <param name="defendersForge"><inheritdoc cref="DefendersForge" path="/summary"/></param>
        /// <param name="voidVault"><inheritdoc cref="VoidVault" path="/summary"/></param>
        public Inventory(
            BasicItem[] backpack,
            BasicItem[] equipment,
            BasicItem[] dyes,
            BasicItem[] miscEquips,
            BasicItem[] miscDyes,
            BasicItem[] piggyBank,
            BasicItem[] safe,
            BasicItem[] defendersForge,
            BasicItem[] voidVault)
        {
            if (backpack.Length != BackpackSize)
            {
                throw new ArgumentException("Array is incorrectly sized.", nameof(backpack));
            }

            if (equipment.Length != EquipmentSize)
            {
                throw new ArgumentException("Array is incorrectly sized.", nameof(equipment));
            }

            if (dyes.Length != DyesSize)
            {
                throw new ArgumentException("Array is incorrectly sized.", nameof(dyes));
            }

            if (miscEquips.Length != MiscEquipsSize)
            {
                throw new ArgumentException("Array is incorrectly sized.", nameof(miscEquips));
            }

            if (miscDyes.Length != MiscDyesSize)
            {
                throw new ArgumentException("Array is incorrectly sized.", nameof(miscDyes));
            }

            if (piggyBank.Length != PiggyBankSize)
            {
                throw new ArgumentException("Array is incorrectly sized.", nameof(piggyBank));
            }

            if (safe.Length != SafeSize)
            {
                throw new ArgumentException("Array is incorrectly sized.", nameof(safe));
            }

            if (defendersForge.Length != DefendersForgeSize)
            {
                throw new ArgumentException("Array is incorrectly sized.", nameof(defendersForge));
            }

            if (voidVault.Length != VoidVaultSize)
            {
                throw new ArgumentException("Array is incorrectly sized.", nameof(voidVault));
            }

            _backpack = backpack;
            _equipment = equipment;
            _dyes = dyes;
            _miscEquips = miscEquips;
            _miscDyes = miscDyes;
            _piggyBank = piggyBank;
            _safe = safe;
            _defendersForge = defendersForge;
            _voidVault = voidVault;
        }
    }
}