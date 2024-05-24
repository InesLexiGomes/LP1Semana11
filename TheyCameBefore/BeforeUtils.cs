using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T item) where T : IComparable<T>
        {
            foreach (T i in items)
            {
                if (i.CompareTo(item) < 0) yield return i;
            }
        }
    }
}