using System;

namespace Nvipt.Core
{
    public class PlayerStyle
    {
        /// <summary>
        /// Represents the amount of clothes/skin variants there are.
        /// </summary>
        public static readonly byte ClothesCount = 12;

        private byte _clothesType;

        /// <summary>
        /// Represents the player's skin variant or clothes type.
        /// </summary>
        public byte ClothesType
        {
            get => _clothesType;

            set
            {
                if (value >= ClothesCount)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, nameof(ClothesType) + " is out of bounds.");
                }

                _clothesType = value;
            }
        }

        /// <summary>
        /// Represents the amount of hair there is.
        /// </summary>
        public static readonly byte HairCount = 163;

        private byte _hairType;

        /// <summary>
        /// Represents the player's hair type.
        /// </summary>
        public byte HairType
        {
            get => _hairType;

            set
            {
                if (value >= HairCount)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, nameof(HairType) + " is out of bounds.");
                }

                _hairType = value;
            }
        }

        private HairDyeType _hairDye;

        /// <summary>
        /// Represents the player's hair dye's type.
        /// </summary>
        public HairDyeType HairDye
        {
            get => _hairDye;

            set
            {
                if (value < HairDyeType.None && value >= HairDyeType.Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, nameof(HairDye) + " is out of bounds.");
                }

                _hairDye = value;
            }
        }

        /// <summary>
        /// Represents what equipment is hidden.
        /// </summary>
        public bool[] HideEquipment { get; }

        /// <summary>
        /// Represents what miscellaneous equipment is hidden.
        /// </summary>
        public bool[] HideMisc { get; }

        /// <summary>
        /// Represents the player's hair color.
        /// </summary>
        public Color HairColor { get; set; }

        /// <summary>
        /// Represents the player's skin color.
        /// </summary>
        public Color SkinColor { get; set; }

        /// <summary>
        /// Represents the player's eye color.
        /// </summary>
        public Color EyeColor { get; set; }

        /// <summary>
        /// Represents the player's shirt color.
        /// </summary>
        public Color ShirtColor { get; set; }

        /// <summary>
        /// Represents the player's undershirt color.
        /// </summary>
        public Color UndershirtColor { get; set; }

        /// <summary>
        /// Represents the player's pants' color.
        /// </summary>
        public Color PantsColor { get; set; }

        /// <summary>
        /// Represents the player's shoe color.
        /// </summary>
        public Color ShoeColor { get; set; }
    }
}
