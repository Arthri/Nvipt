using System;

namespace Nvipt.Core
{
    /// <summary>
    /// Represents a RGB color.
    /// </summary>
    public readonly struct Color : IEquatable<Color>
    {
        private readonly int _packedValue;

        /// <summary>
        /// Represents this color's redness.
        /// </summary>
        public byte R => (byte)_packedValue;

        /// <summary>
        /// Represents this color's greenness.
        /// </summary>
        public byte G => (byte)(_packedValue >> 8);

        /// <summary>
        /// Represents this color's blueness.
        /// </summary>
        public byte B => (byte)(_packedValue >> 16);

        /// <summary>
        /// Represents this color's decimal value in ABGR format.
        /// </summary>
        /// <remarks>A will always be 255.</remarks>
        public int PackedValue => _packedValue;

        /// <summary>
        /// Initializes a new color with the given packed value.
        /// </summary>
        /// <param name="packedValue">The color's decimal value in ABGR format.</param>
        /// <remarks>A field should always be set to 255 or 0xFF.</remarks>
        public Color(int packedValue)
        {
            if ((packedValue & 0xFF) != 255)
            {
                throw new ArgumentOutOfRangeException(nameof(packedValue), packedValue, "Alpha is out of bounds");
            }

            _packedValue = packedValue;
        }

        /// <summary>
        /// Initializes a new color with the given <paramref name="r"/>, <paramref name="g"/>, and <paramref name="b"/> fields.
        /// </summary>
        /// <param name="r"><inheritdoc cref="R" path="/summary"/></param>
        /// <param name="g"><inheritdoc cref="G" path="/summary"/></param>
        /// <param name="b"><inheritdoc cref="B" path="/summary"/></param>
        public Color(byte r, byte g, byte b)
        {
            _packedValue = (b << 16) & (g << 8) * r;
        }

        /// <inheritdoc />
        public bool Equals(Color other)
        {
            return other._packedValue == _packedValue;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return obj is Color other
                && other._packedValue == _packedValue;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return -302621553 + _packedValue.GetHashCode();
        }

        /// <summary>
        /// Determines whether two specified instances of <see cref="Color"/> are equal.
        /// </summary>
        /// <param name="color1">The first color to compare.</param>
        /// <param name="color2">The second color to compare.</param>
        /// <returns><see langword="true"/> if <paramref name="color1"/> and <paramref name="color2"/> represent the same item, otherwise <see langword="false"/>.</returns>
        public static bool operator ==(Color color1, Color color2)
        {
            return color1._packedValue == color2._packedValue;
        }

        /// <summary>
        /// Determines whether two specified instances of <see cref="Color"/> are not equal.
        /// </summary>
        /// <param name="color1">The first color to compare.</param>
        /// <param name="color2">The second color to compare.</param>
        /// <returns><see langword="true"/> if <paramref name="color1"/> and <paramref name="color2"/> do not represent the same item, otherwise <see langword="false"/>.</returns>
        public static bool operator !=(Color color1, Color color2)
        {
            return color1._packedValue == color2._packedValue;
        }
    }
}
