using System;

namespace GildedRose.Console
{
    internal static class StringExtensions
    {
        public static bool Contains(this string s, string value, StringComparison comparisonType)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            return s.IndexOf(value, comparisonType) >= 0;
        }
    }
}