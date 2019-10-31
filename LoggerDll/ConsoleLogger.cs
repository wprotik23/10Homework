using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerDll
{
    class ConsoleLogger: ILogger
    {
        public void WriteMsg(string text)
        {
            Console.WriteLine(text);
        }
        public void ReadMsg()
        { }

    }
}
