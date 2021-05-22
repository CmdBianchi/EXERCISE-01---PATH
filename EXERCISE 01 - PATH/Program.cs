using System;
using System.IO;
namespace EXERCISE_01___PATH {
    //-----> START
    ///////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\myfolder\files1.txt";

            Console.WriteLine("DirectorySeparatorChar: " +Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirctoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: "+Path.GetFileName(path));
            Console.WriteLine("GetExtension: "+Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPAth: "+Path.GetFullPath(path));
            Console.WriteLine("GetTempPath"+Path.GetTempPath());
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
