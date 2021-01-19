using System.Collections.Generic;
using System.Linq;
using ApprovalUtilities.Utilities;
using csharpcore.Items;

namespace csharpcore
{
    public class GildedRose
    {
        private IEnumerable<Item> _items;

        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            new SpecifiedItems(_items).SpecifyItems();

            // for (var i = 0; i < _items.Count(); i++)
            // {
            //     if (_items.ElementAt(i).Name != "Aged Brie" && _items.ElementAt(i).Name != "Backstage passes to a TAFKAL80ETC concert")
            //     {
            //         if (_items.ElementAt(i).Quality > 0)
            //         {
            //             if (_items.ElementAt(i).Name != "Sulfuras, Hand of Ragnaros")
            //             {
            //                 _items.ElementAt(i).Quality = _items.ElementAt(i).Quality - 1;
            //             }
            //         }
            //     }
            //     else
            //     {
            //         if (_items.ElementAt(i).Quality < 50)
            //         {
            //             _items.ElementAt(i).Quality = _items.ElementAt(i).Quality + 1;
            //
            //             if (_items.ElementAt(i).Name == "Backstage passes to a TAFKAL80ETC concert")
            //             {
            //                 if (_items.ElementAt(i).SellIn < 11)
            //                 {
            //                     if (_items.ElementAt(i).Quality < 50)
            //                     {
            //                         _items.ElementAt(i).Quality = _items.ElementAt(i).Quality + 1;
            //                     }
            //                 }
            //
            //                 if (_items.ElementAt(i).SellIn < 6)
            //                 {
            //                     if (_items.ElementAt(i).Quality < 50)
            //                     {
            //                         _items.ElementAt(i).Quality = _items.ElementAt(i).Quality + 1;
            //                     }
            //                 }
            //             }
            //         }
            //     }
            //
            //     if (_items.ElementAt(i).Name != "Sulfuras, Hand of Ragnaros")
            //     {
            //         _items.ElementAt(i).SellIn = _items.ElementAt(i).SellIn - 1;
            //     }
            //
            //     if (_items.ElementAt(i).SellIn < 0)
            //     {
            //         if (_items.ElementAt(i).Name != "Aged Brie")
            //         {
            //             if (_items.ElementAt(i).Name != "Backstage passes to a TAFKAL80ETC concert")
            //             {
            //                 if (_items.ElementAt(i).Quality > 0)
            //                 {
            //                     if (_items.ElementAt(i).Name != "Sulfuras, Hand of Ragnaros")
            //                     {
            //                         _items.ElementAt(i).Quality = _items.ElementAt(i).Quality - 1;
            //                     }
            //                 }
            //             }
            //             else
            //             {
            //                 _items.ElementAt(i).Quality = _items.ElementAt(i).Quality - _items.ElementAt(i).Quality;
            //             }
            //         }
            //         else
            //         {
            //             if (_items.ElementAt(i).Quality < 50)
            //             {
            //                 _items.ElementAt(i).Quality = _items.ElementAt(i).Quality + 1;
            //             }
            //         }
            //     }
            // }
        }
    }
}