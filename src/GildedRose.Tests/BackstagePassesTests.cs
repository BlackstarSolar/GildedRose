using FluentAssertions;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class BackstagePassesTests : ProgramTests
    {
        [Fact]
        public void Quality_is_increased_by_one_while_sellin_date_is_more_then_ten_days()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 10 };

            Items.Add(item);

            Target.UpdateQuality();

            item.Quality.Should().Be(11);
        }

        [Fact]
        public void Quality_is_increased_by_two_when_sellin_date_is_ten_days()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 };

            Items.Add(item);

            Target.UpdateQuality();

            item.Quality.Should().Be(12);
        }

        [Fact]
        public void Quality_is_increased_by_two_when_sellin_date_less_than_ten_days()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 10 };

            Items.Add(item);

            Target.UpdateQuality();

            item.Quality.Should().Be(12);
        }

        [Fact]
        public void Quality_is_increased_by_two_when_sellin_date_more_than_five_days()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 10 };

            Items.Add(item);

            Target.UpdateQuality();

            item.Quality.Should().Be(12);
        }

        [Fact]
        public void Quality_is_increased_by_three_when_sellin_date_is_five_days()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 };

            Items.Add(item);

            Target.UpdateQuality();

            item.Quality.Should().Be(13);
        }

        [Fact]
        public void Quality_is_increased_by_three_when_sellin_date_less_than_five_days()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 10 };

            Items.Add(item);

            Target.UpdateQuality();

            item.Quality.Should().Be(13);
        }
        
        [Fact]
        public void Quality_is_increased_by_three_when_sellin_date_at_least_one_day()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 10 };

            Items.Add(item);

            Target.UpdateQuality();

            item.Quality.Should().Be(13);
        }

        [Fact]
        public void Quality_drops_to_zero_after_the_concert()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 };

            Items.Add(item);

            Target.UpdateQuality();

            item.Quality.Should().Be(0);
        }

        [Fact]
        public void Quality_cannot_increase_beyond_fifty()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 50 };

            Items.Add(item);

            Target.UpdateQuality();

            item.Quality.Should().Be(50);
        }
    }
}