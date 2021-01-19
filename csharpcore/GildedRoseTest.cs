using Xunit;
using System.Collections.Generic;
using csharpcore.Items;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Fact]
        public void AgedBrie_IncreasesQuality()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 1} };
            BootstrapWith(items);
            
            Assert.Equal(expected: 51, items[0].Quality);
        }

        [Fact]
        public void BackstagePass_ZeroQualityAfterConcert()
        {
            IList<Item> items = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                }
            };
            BootstrapWith(items);
            
            Assert.Equal(expected: 0, items[0].Quality);
        }

        [Fact]
        public void ConjuredManaCake_IncreasesAsTwiceAsNormalItem()
        {
            IList<Item> items = new List<Item> {new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}};
            BootstrapWith(items);
            
            Assert.Equal(expected: -112, items[0].Quality);
        }

        private static void BootstrapWith(IList<Item> items)
        {
            GildedRose app = new GildedRose(items);
            for (var i = 0; i <= 30; i++)
            {
                app.UpdateQuality();
            }
        }
    }
}