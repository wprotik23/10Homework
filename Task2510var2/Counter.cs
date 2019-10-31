using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using Printers;

namespace Task2510var2
{
    public  class Counter
    {
        public IPrinter printer;

        public  void Countfiles(List<FileInfo> AllFiles, IPrinter printer)
        {
            var query = AllFiles.GroupBy(x => x.Name)
              .Where(g => g.Count() > 0)
              .ToDictionary(x => x.Key, y => y.Count());
            foreach (KeyValuePair<string, int> f in query)
            {
               printer.Print(f.Key + " " + f.Value);
            }
        }
    }
}
