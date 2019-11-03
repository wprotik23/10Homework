using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration.FileExtensions;
using System.IO;
using System.Collections.Generic;
using ExcelDataReader;
using System.Data;

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
            FileStream fs = new FileStream(config["file"],FileMode.Open, FileAccess.Read);

            List<string> lst = new List<string>();
            IExcelDataReader excelReader;
            //excelReader = ExcelReaderFactory.CreateReader(fs);

            //lst.Add( excelReader.Read().ToString());                                                                    //чтение данных

            foreach (var l in lst)
            {
                Console.WriteLine(l);
            }

        }
    }
}
