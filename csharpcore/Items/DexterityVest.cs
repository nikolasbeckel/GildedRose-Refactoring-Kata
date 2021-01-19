namespace csharpcore.Items
{
    public sealed class DexterityVest : AgingItem
    {
        public DexterityVest(Item item) : base(item)
        {
        }
        
        private protected override void ChangeQuality() => _item.Quality -= _item.SellIn >= 0 ? 1 : 2;
    }
}