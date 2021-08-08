using Nvipt.Core;
using Terraria;

namespace Nvipt.OTAPI.Extensions
{
    /// <summary>
    /// Provides helper methods for <see cref="Terraria.Item"/>.
    /// </summary>
    public static class ItemExtensions
    {
        /// <summary>
        /// Determines whether two specified instances of <see cref="Item"/> and <see cref="BasicItem"/> are equal.
        /// </summary>
        /// <param name="item1">The first item to compare.</param>
        /// <param name="item2">The second item to compare.</param>
        /// <returns><see langword="true"/> if <paramref name="item1"/> and <paramref name="item2"/> represent the same item, otherwise <see langword="false"/>.</returns>
        /// <remarks>Returns true for two different items with the same ID, stack and prefix.</remarks>
        public static bool IsEqual(this Item item1, BasicItem item2)
        {
            if (item1 is null)
            {
                return item2 is null;
            }
            else
            {
                return item1.type == item2.ID
                    && item1.stack == item2.Stack
                    && item1.prefix == item2.Prefix;
            }
        }

        /// <summary>
        /// Creates a basic item based of the current item.
        /// </summary>
        /// <param name="item">The current item.</param>
        /// <returns>A basic item based off the current item.</returns>
        public static BasicItem ToBasicItem(this Item item)
        {
            return new BasicItem
            {
                ID = (short)item.netID,
                Stack = (short)item.stack,
                Prefix = item.prefix
            };
        }

        /// <summary>
        /// Converts an array of <see cref="Terraria.Item"/> into an array of <see cref="Nvipt.Core.BasicItem"/>.
        /// </summary>
        /// <param name="items">The array of <see cref="Terraria.Item"/> to convert.</param>
        /// <returns>An array of <see cref="Nvipt.Core.BasicItem"/>.</returns>
        public static BasicItem[] ToBasicItem(this Item[] items)
        {
            var basicItems = new BasicItem[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                basicItems[i] = items[i].ToBasicItem();
            }

            return basicItems;
        }
    }
}
