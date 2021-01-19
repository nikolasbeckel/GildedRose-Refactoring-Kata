using System.Collections.Generic;
using System.Linq;
using ApprovalUtilities.Utilities;
using csharpcore.Items;

namespace csharpcore
{
    public sealed class SpecifiedItems
    {
        private readonly IEnumerable<Item> _items;

        public SpecifiedItems(IEnumerable<Item> items)
        {
            _items = items;
        }

        public void SpecifyItems()
        {
            _items.ForEach(it =>
            {
                switch (it.Name)
                {
                    case "Sulfuras, Hand of Ragnaros":
                        new Sulfuras(it).AgingADay();
                        break;
                    case "Aged Brie":
                        new AgedBrie(it).AgingADay();
                        break;
                    case "+5 Dexterity Vest":
                        new DexterityVest(it).AgingADay();
                        break;
                    case "Elixir of the Mongoose":
                        new ElixirOfMongoose(it).AgingADay();
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        new BackstagePass(it).AgingADay();
                        break;
                    case "Conjured Mana Cake":
                        new ConjuredManaCake(it).AgingADay();
                        break;
                    default:
                        return;
                }
            });
        }
    }
}