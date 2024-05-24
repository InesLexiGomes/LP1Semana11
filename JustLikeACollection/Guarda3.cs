using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
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

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0;i<3;i++)
            {
                switch (i)
                {
                    case 0: 
                        yield return val1;
                        break;
                    case 1: 
                        yield return val2;
                        break;
                    case 2: 
                        yield return val3;
                        break;
                }
            }
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

        public void Add(T item)
        {
            if (Equals(val1, default(T))) val1 = item;
            else if (Equals(val2, default(T))) val2 = item;
            else if (Equals(val3, default(T))) val3 = item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}