using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    static class Checker
    {
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            int n = 0;
            foreach (object item in items)
            {
                if (item is T) n++;
            }
            return n;
        }
    }
}