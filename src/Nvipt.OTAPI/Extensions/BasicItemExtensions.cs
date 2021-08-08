using Terraria;

namespace Nvipt.OTAPI.Extensions
{
    public static class BasicItemExtensions
    {
        /// <summary>
        /// Determines whether two specified instances of <see cref="BasicItem"/> and <see cref="Item"/> are equal
        /// </summary>
        /// <param name="item1">The first item to compare</param>
        /// <param name="item2">The second item to compare</param>
        /// <returns><see langword="true"/> if <paramref name="item1"/> and <paramref name="item2"/> represent the same item, otherwise <see langword="false"/></returns>
        /// <remarks>Returns true for two different <paramref name="item2"/> with the same ID, stack and prefix</remarks>
        public static bool IsEqual(this BasicItem item1, Item item2)
        {
            if (item1 is null)
            {
                return item2 is null;
            }
            else
            {
                return item1.ID == item2.type
                    && item1.Stack == item2.stack
                    && item1.Prefix == item2.prefix;
            }
        }
    }
}
