using Terraria;

namespace Nvipt.OTAPI
{
    public interface IItemConverter
    {
        BasicItem ToBasicItem(Item item);
    }
}
