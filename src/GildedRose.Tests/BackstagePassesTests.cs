using FluentAssertions;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class BackstagePassesTests : ProgramTests
    {
        public BackstagePassesTests()
        {
           Item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 10 };
        }

        [Fact]
        public void Quality_is_increased_by_one_while_sellin_date_is_more_then_ten_days()
        {
            UpdateQualityWithItem();

            Item.Quality.Should().Be(11);
        }

        [Fact]
        public void Quality_is_increased_by_two_when_sellin_date_is_ten_days()
        {
            Item.SellIn = 10;

            UpdateQualityWithItem();

            Item.Quality.Should().Be(12);
        }

        [Fact]
        public void Quality_is_increased_by_two_when_sellin_date_less_than_ten_days()
        {
            Item.SellIn = 9;

            UpdateQualityWithItem();

            Item.Quality.Should().Be(12);
        }

        [Fact]
        public void Quality_is_increased_by_two_when_sellin_date_more_than_five_days()
        {
            Item.SellIn =  6;

            UpdateQualityWithItem();

            Item.Quality.Should().Be(12);
        }

        [Fact]
        public void Quality_is_increased_by_three_when_sellin_date_is_five_days()
        {
            Item.SellIn = 5;

            UpdateQualityWithItem();

            Item.Quality.Should().Be(13);
        }

        [Fact]
        public void Quality_is_increased_by_three_when_sellin_date_less_than_five_days()
        {
            Item.SellIn = 4;

            UpdateQualityWithItem();

            Item.Quality.Should().Be(13);
        }
        
        [Fact]
        public void Quality_is_increased_by_three_when_sellin_date_at_least_one_day()
        {
            Item.SellIn = 1;

            UpdateQualityWithItem();

            Item.Quality.Should().Be(13);
        }

        [Fact]
        public void Quality_drops_to_zero_after_the_concert()
        {
            Item.SellIn = 0;

            UpdateQualityWithItem();

            Item.Quality.Should().Be(0);
        }

        [Fact]
        public void Quality_cannot_increase_beyond_fifty()
        {
            Item.Quality = 50;

            UpdateQualityWithItem();

            Item.Quality.Should().Be(50);
        }
    }
}