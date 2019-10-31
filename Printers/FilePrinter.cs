using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.FileExtensions;
using System.IO;

namespace Printers
{
    public class FilePrinter: IPrinter
    {
       
        public string file;
        public FilePrinter(string file)
        {
            this.file = file;
        }
        public void Print(string str)
        {
            StreamWriter sw = new StreamWriter(file, true);
            using (sw)
            {
                
                sw.WriteLine(str);
            }

            

        }

    }
}
