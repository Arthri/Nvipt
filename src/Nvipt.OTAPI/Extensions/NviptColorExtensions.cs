using NviptColor = Nvipt.Core.Color;
using XNAColor = Microsoft.Xna.Framework.Color;

namespace Nvipt.OTAPI.Extensions
{
    /// <summary>
    /// Provides helper methods for <see cref="Nvipt.Core.Color"/>.
    /// </summary>
    public static class NviptColorExtensions
    {
        /// <summary>
        /// Returns a <see cref="Microsoft.Xna.Framework.Color"/> that represents the current color.
        /// </summary>
        /// <param name="color">The current color.</param>
        /// <returns>A <see cref="Microsoft.Xna.Framework.Color"/> that represents the current color.</returns>
        public static XNAColor ToXNAColor(this NviptColor color)
        {
            return new XNAColor((uint)color.PackedValue);
        }
    }
}
