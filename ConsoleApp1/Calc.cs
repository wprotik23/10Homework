using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Calc
    {
        public int x;
        public int y;
        public Iprint prt;

        public Calc( Iprint pr)
        {
            pr.input();
            this.x = pr.x;
            this.y = pr.y;
            prt = pr;
        }
        public double operation()
        {
            return x * y;
        }
        public void print(string s)
        {
            prt.output(s);
        }
        
    }
}
