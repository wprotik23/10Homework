using System;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.FileExtensions;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Printers;

namespace Task2510var2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            string str = config["folder1"];
            string str2 = config["folder2"];
            IPrinter pr;
            if (config["PrintMode"] == "File")
            {
                pr = new FilePrinter(config["filePrint"]);
            }
            else
                pr = new ConsolePrinter();


            List<FileInfo> AllFiles = new List<FileInfo>(); 
            
            DirectoryCheck dc = new DirectoryCheck();
            dc.DirectoryInside(str, AllFiles);
            dc.DirectoryInside(str2, AllFiles);

            Counter count = new Counter();
            count.Countfiles(AllFiles, pr);
        }              
    }
}
