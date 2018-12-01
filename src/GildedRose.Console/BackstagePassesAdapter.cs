namespace GildedRose.Console
{
    public class BackstagePassesAdapter : IItem
    {
        private readonly AppreciatingItemDecorator _item;

        public BackstagePassesAdapter(Item item)
        {
            _item = new AppreciatingItemDecorator(item);
        }

        public void Update()
        {
            if (_item.SellIn == 0)
            {
                _item.Quality = 0;
                _item.Age();
                return;
            }
            
            var amount = 1;
            if (_item.SellIn <= 10)
            {
                amount = 2;
            }

            if (_item.SellIn <= 5)
            {
                amount = 3;
            }

            _item.IncreaseQualityBy(amount);
            _item.Age();

        }

    }
}