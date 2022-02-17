using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _030__Indexers
{
    class IndexedNames
    {
        private string[] nameList = new string[size];
        public static int size = 10;

        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
            {
                nameList[i] = "N/A";
            }
        }

        // Use of Indexers
        public string this[int index]
        {
            get
            {
                string temp = null;

                if (index >= 0 && index <= size - 1)
                {
                    temp = nameList[index];
                }
                else
                {
                    temp = "";
                }

                return temp;
            }

            set
            {
                nameList[index] = value;
            }
        }

        // Overloaded Indexers
        public int this[string name]
        {
            get
            {
                int index = 0;

                while (index < size)
                {
                    if (nameList[index] == name)
                    {
                        return index;
                    }

                    index++;
                }

                return index;
            }
        }
    }
}
