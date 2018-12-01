using System.Collections.Generic;
using GildedRose.Console;

namespace GildedRose.Tests
{
    public abstract class ProgramTests
    {
        public IList<Item> Items { get; private set; }

        public Program Target { get; private set; }

        protected ProgramTests()
        {
            Items = new List<Item>();
            Target = new Program(Items);
        }
    }
}