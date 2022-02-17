using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _020__Polymorphism
{
    class VirtualShape
    {
        protected int width, height;

        public VirtualShape(int w = 0, int h = 0)
        {
            width = w;
            height = h;
        }

        public virtual int Area()
        {
            Console.WriteLine(" - Virtual parent class area - ");
            return 0;
        }
    }

    class VirtualRectangle : VirtualShape
    {
        public VirtualRectangle(int w = 0, int h = 0)
            : base(w, h)
        {

        }

        public override int Area()
        {
            Console.WriteLine(" - Virtual rectangle class area - ");
            return width * height;
        }
    }

    class VirtualTriangle : VirtualShape
    {
        public VirtualTriangle(int w = 0, int h = 0)
            : base(w, h)
        {

        }

        public override int Area()
        {
            Console.WriteLine(" - Virtual triangle class area - ");
            return (width * height) / 2;
        }
    }

    class Caller
    {
        public void CallArea(VirtualShape vr)
        {
            int a;
            a = vr.Area();
            Console.WriteLine("Area: {0}", a);
        }
    }
}
