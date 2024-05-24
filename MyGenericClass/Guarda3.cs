using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T val1;
        private T val2;
        private T val3;
        public Guarda3()
        {
            val1 = default;
            val2 = default;
            val3 = default;
        }
        public T GetItem(int i)
        {
            switch (i)
            {
                case 0: return val1;
                case 1: return val2;
                case 2: return val3;
                default: throw new IndexOutOfRangeException();
            }
        }
        public void SetItem(int i, T val)
        {
            switch(i)
            {
                case 0: 
                    val1 = val;
                    break;
                case 1: 
                    val2 = val;
                    break;
                case 2: 
                    val3 = val;
                    break;
                default: throw new IndexOutOfRangeException();
            }
        }
 }
}