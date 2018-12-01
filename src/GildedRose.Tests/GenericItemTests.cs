using System.Collections.Generic;
using FluentAssertions;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class GenericItemTests
    {
        private readonly IList<Item> _items;

        private readonly Program _target;

        public GenericItemTests()
        {
            _items = new List<Item>();
            _target = new Program(_items);
        }

        [Fact]
        public void SellIn_is_lowered_by_one_by_default()
        {
            var item = new Item { SellIn = 5, Quality = 10};

            _items.Add(item);

            _target.UpdateQuality();

            item.SellIn.Should().Be(4);
        }

        [Fact]
        public void Quality_is_lowered_by_one_before_sellin_has_passed()
        {
            var item = new Item { SellIn = 1, Quality = 10 };

            _items.Add(item);

            _target.UpdateQuality();

            item.Quality.Should().Be(9);
        }

        [Fact]
        public void Quality_is_lowered_twice_as_fast_once_sellin_has_passed()
        {
            var item = new Item { SellIn = 0, Quality = 10 };

            _items.Add(item);

            _target.UpdateQuality();

            item.Quality.Should().Be(8);
        }

        [Fact]
        public void Quality_cannot_be_reduced_below_zero()
        {
            var item = new Item { SellIn = 1, Quality = 0 };

            _items.Add(item);

            _target.UpdateQuality();

            item.Quality.Should().Be(0);
        }
    }
}