using FluentAssertions;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class SulfurasTests : ProgramTests
    {
        [Fact]
        public void Never_has_to_be_sold()
        {
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 10 };

            Items.Add(item);

            Target.UpdateQuality();

            item.SellIn.Should().Be(1);
        }

        [Fact]
        public void Does_not_reduce_in_quality()
        {
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 10 };

            Items.Add(item);

            Target.UpdateQuality();

            item.Quality.Should().Be(10);
        }
    }
}