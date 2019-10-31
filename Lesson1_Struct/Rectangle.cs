using System;
using System.Collections.Generic;
using System.Text;
using Printers;

namespace Lesson1_Struct
{
    struct Rectangle : ISize, ICoordinates
    {
        public int wight { get; set; }
        public int height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public IPrinter printer { get; set; }

        public Rectangle(int w, int h, int x, int y, IPrinter pr)
        {
            wight = w;
            height = h;
            X = x;
            Y = y;
            printer = pr;
        }
        public int perimetr()
        {
            return (wight + height) * 2;
        }
        public void Print()
        {
            printer.Print(perimetr().ToString());
        }


    }
}
