namespace csharpcore.Items
{
    public sealed class ElixirOfMongoose : AgingItem
    {
        public ElixirOfMongoose(Item item) : base(item)
        {
        }
        
        private protected override void ChangeQuality() => _item.Quality -= _item.SellIn >= 0 ? 1 : 2;
    }
}