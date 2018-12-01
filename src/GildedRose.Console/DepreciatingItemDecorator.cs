using System;

namespace GildedRose.Console
{
    public class DepreciatingItemDecorator : AgingItemDecorator
    {
        private const int MinQuality = 0;

        public DepreciatingItemDecorator(Item item) : base(item)
        {
        }

        public void DecreaseQualityBy(int amount)
        {
            Quality = Math.Max(MinQuality, Quality - amount);
        }
    }
}