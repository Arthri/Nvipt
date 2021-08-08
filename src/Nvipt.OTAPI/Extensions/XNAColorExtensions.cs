using NviptColor = Nvipt.Core.Color;
using XNAColor = Microsoft.Xna.Framework.Color;

namespace Nvipt.OTAPI.Extensions
{
    /// <summary>
    /// Provides helper methods for <see cref="Microsoft.Xna.Framework.Color"/>.
    /// </summary>
    public static class XNAColorExtensions
    {
        /// <summary>
        /// Returns a <see cref="Nvipt.Core.Color"/> that represents the current color.
        /// </summary>
        /// <param name="color">The current color.</param>
        /// <returns>A <see cref="Nvipt.Core.Color"/> that represents the current color.</returns>
        public static NviptColor ToNviptColor(this XNAColor color)
        {
            return new NviptColor((int)color.packedValue);
        }
    }
}
