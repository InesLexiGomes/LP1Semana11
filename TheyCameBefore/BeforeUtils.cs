using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    static class Checker
    {
        public static int GetTheOnesBefore<T>(IComparable<T> items, T item) where T : struct 
        {
            List<T> list = new List<T>();
            foreach (T i in items)
            {
                if (i < item) list.add(i);
            }
            return list;
        }
    }
}