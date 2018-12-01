using FluentAssertions;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class AgedBrieTests : ProgramTests
    {
        [Fact]
        public void Quality_is_increased_by_one_before_sellin_has_passed()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 1, Quality = 10 };

            Items.Add(item);

            Target.UpdateQuality();

            item.Quality.Should().Be(11);
        }

        [Fact]
        public void Quality_cannot_increase_beyond_fifty()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 1, Quality = 50 };

            Items.Add(item);

            Target.UpdateQuality();

            item.Quality.Should().Be(50);
        }
    }
}