using System;
using System.IO;

namespace dotnet_fileNdirectory_manipulation
{
    class CopyFiles
    {
        public void Exec(string rootPath, string destination)
        {

            Console.WriteLine("Start copying files ...");

            var filesInCurrentDirectory = Directory.GetFiles(rootPath, "*.csv", SearchOption.TopDirectoryOnly);

            DateTime date1 = DateTime.Now;
            var now = date1.ToString("yyyyMMddTHH_mm_ssZ");
            foreach (var file in filesInCurrentDirectory)
            {
                File.Copy(file, $"{destination}{now}{Path.GetFileNameWithoutExtension(file)}.cdp", true);
            }

        }
    }
}

