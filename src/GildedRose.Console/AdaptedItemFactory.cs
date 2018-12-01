using System.Collections.Generic;

namespace GildedRose.Console
{
    public class AdaptedItemFactory
    {
        public IEnumerable<IItem> CreateAdaptedItemsFrom(IEnumerable<Item> items)
        {
            foreach (var item in items)
            {
                switch (item.Name)
                {

                    case "Aged Brie":
                        yield return new AgedBrieAdapter(item);
                        continue;
                    case "Sulfuras, Hand of Ragnaros":
                        yield return new LegendaryItemAdapter();
                        continue;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        yield return new BackstagePassesAdapter(item);
                        continue;
                    default:
                        yield return new GenericItemAdapter(item);
                        break;
                }
            }
        }
    }
}