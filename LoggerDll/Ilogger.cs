using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerDll
{
    interface ILogger
    {
        void WriteMsg(string text);
        void ReadMsg();
    }
}
