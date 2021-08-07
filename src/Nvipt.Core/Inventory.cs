using System;
using TShockAPI;

namespace Nvipt
{
    public class Inventory
    {
        private BasicItem[] _items;

        public BasicItem[] Items
        {
            get => _items;

            set
            {
                if (value.Length != NetItem.MaxInventory)
                {
                    throw new ArgumentException($"{nameof(value)}'s length must equal {NetItem.MaxInventory}", nameof(value));
                }

                _items = value;
            }
        }
    }
}