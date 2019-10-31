using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ConsoleCalc:Iprint
    {
        public int x { get; set; }
        public int y { get; set; }
        public void input()
        {
            x = Convert.ToInt32( Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
        }
        public void output(string str)
        {
            Console.WriteLine(str);
            
        }

    }
}
