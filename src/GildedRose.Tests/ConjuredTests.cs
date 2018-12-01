using FluentAssertions;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class ConjuredTests : ProgramTests
    {
        public ConjuredTests()
        {
            Item = new Item { Name = "Conjured item", SellIn = 5, Quality = 10 };
        }

        [Fact]
        public void SellIn_is_lowered_by_one_when_updated()
        {
            UpdateQualityWithItem();

            Item.SellIn.Should().Be(4);
        }

        [Fact]
        public void Quality_is_lowered_by_two_before_sellin_has_passed()
        {
            Item.SellIn = 1;

            UpdateQualityWithItem();

            Item.Quality.Should().Be(8);
        }

        [Fact]
        public void Quality_is_lowered_twice_as_fast_once_sellin_has_passed()
        {
            Item.SellIn = 0;

            UpdateQualityWithItem();

            Item.Quality.Should().Be(6);
        }

        [Fact]
        public void Quality_cannot_be_reduced_below_zero()
        {
            Item.Quality = 0;

            UpdateQualityWithItem();

            Item.Quality.Should().Be(0);
        }
    }
}