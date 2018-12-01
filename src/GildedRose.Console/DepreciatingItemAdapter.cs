namespace GildedRose.Console
{
    public abstract class DepreciatingItemAdapter : IItem
    {
        private readonly int _defaultDeprecateQualityAmount;
        private readonly DepreciatingItemDecorator _item;

        protected DepreciatingItemAdapter(Item item, int defaultDeprecateQualityAmount)
        {
            _defaultDeprecateQualityAmount = defaultDeprecateQualityAmount;
            _item = new DepreciatingItemDecorator(item);
        }

        public void Update()
        {
            _item.DecreaseQualityBy(_item.SellIn > 0
                ? _defaultDeprecateQualityAmount
                : _defaultDeprecateQualityAmount * 2);
            _item.Age();
        }
    }
}