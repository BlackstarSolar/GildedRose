namespace GildedRose.Console
{
    public class GenericItemAdapter : IItem
    {
        private readonly DepreciatingItemDecorator _item;

        public GenericItemAdapter(Item item)
        {
            _item = new DepreciatingItemDecorator(item);
        }

        public void Update()
        {
            _item.DecreaseQualityBy(_item.SellIn > 0 ? 1 : 2);
            _item.Age();
        }
    }
}