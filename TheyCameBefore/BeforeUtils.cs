using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    static class Checker
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IComparable<T> items, T item) where T : struct 
        {
            IEnumerable<T> list = new IEnumerable<T>();
            foreach (T i in items)
            {
                if (i < item) list.add(i);
            }
            return list;
        }
    }
}