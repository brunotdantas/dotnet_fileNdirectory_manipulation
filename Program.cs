using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace dotnet_fileNdirectory_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // fonte: https://youtu.be/9mUuJIKq40M

            var a = new ReadWriteFile();
            //a.Exec();

            var b = new Directories();
            //b.Exec(@"C:\temp\demo1234");
            //b.Exec(@"C:\temp\demo");

            var c = new ReadFiles();
            //c.Exec(@"C:\temp\demo");

            var d = new CopyFiles();
            // copia arquivos da pasta do parametro 1 pra 2
            //d.Exec(@"C:\temp\demo\", @"C:\temp\demo\copiedFiles\");

            var e = new MoveFiles();
            // move arquivos da pasta do parametro 1 pra 2
            //e.Exec(@"C:\temp\demo\", @"C:\temp\demo\movedFiles\");

            //Console.ReadKey();
        }
    }
}
