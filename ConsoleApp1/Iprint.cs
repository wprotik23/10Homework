using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Iprint
    {
        public int x { get; set; }
        public int y { get; set; }
        public void input();
        public void output(string str);
    }
}
