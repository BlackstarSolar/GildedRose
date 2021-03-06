﻿using FluentAssertions;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class AgedBrieTests : ProgramTests
    {
        public AgedBrieTests()
        {
            Item = new Item { Name = "Aged Brie", SellIn = 1, Quality = 10 };
        }

        [Fact]
        public void Quality_is_increased_by_one_before_sellin_has_passed()
        {
            UpdateQualityWithItem();

            Item.Quality.Should().Be(11);
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