using Terraria;

namespace Nvipt.OTAPI
{
    public class ItemConverter : IItemConverter
    {
        public virtual BasicItem ToBasicItem(Item item)
        {
            return new BasicItem
            {
                ID = (short)item.netID,
                Stack = (short)item.stack,
                Prefix = item.prefix
            };
        }
    }
}
