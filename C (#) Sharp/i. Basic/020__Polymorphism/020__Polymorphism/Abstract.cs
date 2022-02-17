using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _020__Polymorphism
{
    abstract class AbstractShape
    {
        public abstract int area();
    }

    class AbstractRectangle : AbstractShape
    {
        private int width, height;

        public AbstractRectangle(int w = 0, int h = 0)
        {
            width = w;
            height = h;
        }

        public override int area()
        {
            return width * height;
        }
    }
}
