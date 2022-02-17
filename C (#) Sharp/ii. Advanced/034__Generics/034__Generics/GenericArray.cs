using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _034__Generics
{
    class GenericArray<T>
    {
        private T[] array;

        public GenericArray(int size)
        {
            array = new T[size + 1];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }
    }
}
