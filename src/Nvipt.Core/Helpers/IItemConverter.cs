using Terraria;

namespace Nvipt.Helpers
{
    public interface IItemConverter
    {
        BasicItem ToBasicItem(Item item);
    }
}
