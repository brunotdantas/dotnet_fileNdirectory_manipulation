using System;
using System.IO;

namespace dotnet_fileNdirectory_manipulation
{
    class MoveFiles
    {
        public void Exec(string rootPath, string destination)
        {

            Console.WriteLine($"Start moving files from {rootPath} to {destination} ...");

            var filesInCurrentDirectory = Directory.GetFiles(rootPath, "*.csv", SearchOption.TopDirectoryOnly);
            //var filesInCurrentDirectory = Directory.GetFiles(rootPath, "*algumaCoisa*.csv", SearchOption.TopDirectoryOnly);


            DateTime date1 = DateTime.Now;
            var now = date1.ToString("yyyyMMddTHH_mm_ssZ");
            foreach (var file in filesInCurrentDirectory)
            {
                File.Move(file, $"{destination}{now}{Path.GetFileNameWithoutExtension(file)}.cdp", true);
            }

        }
    }
}

