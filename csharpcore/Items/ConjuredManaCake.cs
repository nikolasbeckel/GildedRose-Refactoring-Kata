namespace csharpcore.Items
{
    public sealed class ConjuredManaCake : AgingItem
    {
        public ConjuredManaCake(Item item) : base(item)
        {
        }
        
        private protected override void ChangeQuality() => _item.Quality -= _item.SellIn >= 0 ? 2 : 4;
    }
}