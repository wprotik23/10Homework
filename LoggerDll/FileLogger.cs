using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LoggerDll
{
    class FileLogger: ILogger
    {
        public void WriteMsg(string text)
        {            
            StreamWriter file = new StreamWriter("log.txt", false);
            file.WriteLine(text);
        }
        public void ReadMsg() 
        { }
    }
}
