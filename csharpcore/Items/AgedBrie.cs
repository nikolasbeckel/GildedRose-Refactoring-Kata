namespace csharpcore.Items
{
    public sealed class AgedBrie : AgingItem
    {
        public AgedBrie(Item item) : base(item) { }

        private protected override void ChangeQuality()
        {
            if (_item.Quality >= 50) return;
            if (_item.SellIn >= 0)
                _item.Quality += 1;
            else
                _item.Quality += 2;
        }
    }
}