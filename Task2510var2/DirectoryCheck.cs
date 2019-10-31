using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task2510var2
{
    class DirectoryCheck
    {              
        public  void DirectoryInside(string dir, List<FileInfo> AllFiles)
        {
            DirectoryInfo dinfo = new DirectoryInfo(dir);
            DirectoryInfo[] subDirInfo = dinfo.GetDirectories();
            foreach (DirectoryInfo d in subDirInfo)
            {
                // Console.WriteLine(d);

                if (d.GetDirectories() != null)
                    DirectoryInside(d.FullName, AllFiles);

            }

            FileInfo[] fileDirInfo = dinfo.GetFiles();
            foreach (FileInfo f in fileDirInfo)
            {
                AllFiles.Add(f);
            }
        }

    }
}
