using System;

namespace GildedRose.Console
{
    public class AppreciatingItemDecorator : AgingItemDecorator
    {
        private const int MaxQuality = 50;

        public AppreciatingItemDecorator(Item item) : base(item)
        {
        }

        public void IncreaseQualityBy(int amount)
        {
            Quality = Math.Min(MaxQuality, Quality + amount);
        }
    }
}