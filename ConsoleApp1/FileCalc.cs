using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class FileCalc:Iprint
    {
        public int x { get; set; }
        public int y { get; set; }
        public void input()
        {
            StreamReader sr = new StreamReader("111.txt", false);
            using ( sr)
            {
                string line;
                line = sr.ReadLine();                
                    x = int.Parse(line);
                line = sr.ReadLine();
                y = int.Parse(line);
                
            }
        }
        public void output(string str)
        {
            StreamWriter sw = new StreamWriter("222.txt", false);
            using (sw)
            {
                sw.WriteLine(str);
            }

        }
    }
}
