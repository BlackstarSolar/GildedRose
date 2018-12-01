using System.Collections.Generic;
using GildedRose.Console;

namespace GildedRose.Tests
{
    public abstract class ProgramTests
    {
        protected IList<Item> Items { get; private set; }

        protected Program Target { get; private set; }

        protected Item Item { get; set; }

        protected ProgramTests()
        {
            Items = new List<Item>();
            Target = new Program(Items);
        }

        protected void UpdateQualityWithItem()
        {
            if (Item != null && !Items.Contains(Item))
            {
                Items.Add(Item);
            }

            Target.UpdateQuality();
        }
    }
}