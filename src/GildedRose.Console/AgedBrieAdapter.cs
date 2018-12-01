namespace GildedRose.Console
{
    public class AgedBrieAdapter : IItem
    {
        private readonly AppreciatingItemDecorator _item;

        public AgedBrieAdapter(Item item)
        {
            _item = new AppreciatingItemDecorator(item);
        }

        public void Update()
        {
            _item.IncreaseQualityBy(1);
            _item.Age();
        }
    }
}