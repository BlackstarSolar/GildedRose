namespace GildedRose.Console
{
    public class AgingItemDecorator : Item
    {
        private readonly Item _item;

        public AgingItemDecorator(Item item)
        {
            _item = item;
        }

        public new string Name
        {
            get { return _item.Name; }
            set { _item.Name = value; }
        }

        public new int SellIn
        {
            get { return _item.SellIn; }
            set { _item.SellIn = value; }
        }

        public new int Quality
        {
            get { return _item.Quality; }
            set { _item.Quality = value; }
        }

        public void Age()
        {
            _item.SellIn--;
        }
    }
}