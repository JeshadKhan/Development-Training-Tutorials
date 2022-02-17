using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _019__Interface
{
    // Base Class
    class Shape
    {
        protected int width;
        protected int height;

        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h)
        {
            height = h;
        }
    }
}
