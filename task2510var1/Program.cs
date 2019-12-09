using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration.FileExtensions;
using System.IO;
using System.Collections.Generic;
using ExcelDataReader;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.Linq;

namespace task2510var1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IConfiguration config = new ConfigurationBuilder()
             .AddJsonFile("appsetting.json", true, true)
                .Build();
            
            string str = config["File"];
            Console.WriteLine(str);
            Console.ReadKey();

            try
            {

                Application ObjExcel = new Application();
                Workbook wb = ObjExcel.Workbooks.Open("C:\\Andrii\\lists.xlsx",
                0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true);
                Worksheet ws = (Worksheet)wb.Sheets[1];
                Microsoft.Office.Interop.Excel.Range usedColumn =
                    (Microsoft.Office.Interop.Excel.Range)ws.UsedRange.Columns[1];

                System.Array myvalues = (System.Array)usedColumn.Cells.Value2;
                string[] strArray = myvalues.OfType<object>().Select(o => o.ToString()).ToArray();
                foreach (var r in strArray)
                {
                    Console.WriteLine(r);
                }
                ObjExcel.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
