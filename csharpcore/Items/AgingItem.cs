namespace csharpcore.Items
{
    public abstract class AgingItem
    {
        public readonly Item _item;

        protected AgingItem(Item item)
        {
            _item = item;
        }
        
        public void AgingADay()
        {
            DecreaseSellIn();
            ChangeQuality();
        }
        
        private void DecreaseSellIn() => _item.SellIn -= 1;
        
        private protected abstract void ChangeQuality();
    }
}