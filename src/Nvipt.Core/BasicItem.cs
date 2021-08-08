using System;

namespace Nvipt
{
    public class BasicItem : IEquatable<BasicItem>
    {
        public short ID { get; set; }

        public short Stack { get; set; }

        public byte Prefix { get; set; }

        /// <summary>
        /// Determines whether two specified instances of <see cref="BasicItem"/> are equal
        /// </summary>
        /// <param name="item1">The first item to compare</param>
        /// <param name="item2">The second item to compare</param>
        /// <returns><see langword="true"/> if <paramref name="item1"/> and <paramref name="item2"/> represent the same item, otherwise <see langword="false"/></returns>
        public static bool operator ==(BasicItem item1, BasicItem item2)
        {
            if (item1 is null)
            {
                return item2 is null;
            }
            else
            {
                return item1.Equals(item2);
            }
        }

        /// <summary>
        /// Determines whether two specified instances of <see cref="BasicItem"/> are not equal
        /// </summary>
        /// <param name="item1">The first item to compare</param>
        /// <param name="item2">The second item to compare</param>
        /// <returns><see langword="true"/> if <paramref name="item1"/> and <paramref name="item2"/> don't represent the same item, otherwise <see langword="false"/></returns>
        public static bool operator !=(BasicItem item1, BasicItem item2)
        {
            if (item1 is null)
            {
                return !(item2 is null);
            }
            else
            {
                return !item1.Equals(item2);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is BasicItem item)
            {
                return Equals(obj);
            }
            return false;
        }

        public bool Equals(BasicItem item2)
        {
            return item2 is null
                && ID == item2.ID
                && Stack == item2.Stack
                && Prefix == item2.Prefix;
        }

        public override int GetHashCode()
        {
            var hashCode = -366924608;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + Stack.GetHashCode();
            hashCode = hashCode * -1521134295 + Prefix.GetHashCode();
            return hashCode;
        }
    }
}