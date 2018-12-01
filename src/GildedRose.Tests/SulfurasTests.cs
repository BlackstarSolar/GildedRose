using FluentAssertions;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class SulfurasTests : ProgramTests
    {
        public SulfurasTests()
        {
            Item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 80 };
        }

        [Fact]
        public void Never_has_to_be_sold()
        {
            UpdateQualityWithItem();

            Item.SellIn.Should().Be(1);
        }

        [Fact]
        public void Does_not_reduce_in_quality()
        {
            UpdateQualityWithItem();

            Item.Quality.Should().Be(80);
        }
    }
}