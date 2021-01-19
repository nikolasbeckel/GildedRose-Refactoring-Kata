namespace csharpcore.Items
{
    public sealed class BackstagePass : AgingItem
    {
        public BackstagePass(Item item) : base(item) { }

        private protected override void ChangeQuality()
        {
            ;
            if (_item.SellIn <= 0) {_item.Quality = 0;}
            if (_item.Quality >= 50) {return;}
            
            if (_item.SellIn > 10)
            {
                _item.Quality += 1;
            }
            else if (_item.SellIn <= 10 && _item.SellIn > 5)
            {
                _item.Quality += 2;
            }
            else if (_item.SellIn <= 5 && _item.SellIn > 0)
            {
                _item.Quality += 3;
            }
        }
    }
}