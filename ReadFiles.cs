using System;
using System.IO;

namespace dotnet_fileNdirectory_manipulation
{
    class ReadFiles
    {
        public void Exec(string rootPath)
        {
            var filesInCurrentDirectory = Directory.GetFiles(rootPath, "*.csv", SearchOption.TopDirectoryOnly);
            var filesAndSubfolderFiles = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            Console.WriteLine("");
            Console.WriteLine("CSV files In Current Directory:  ");
            foreach (var file in filesInCurrentDirectory)
            {
                Console.WriteLine(file);

                // Arquivo sem o caminho: 
                //Console.WriteLine(Path.GetFileName(file));

                // Arquivo sem o caminho: 
                //Console.WriteLine(Path.GetFileNameWithoutExtension(file));

                // Diretório do arquivo: 
                //Console.WriteLine(Path.GetDirectoryName(file));

                //var info = new FileInfo(file);
                //Console.WriteLine($"é possível ler mais informações do arquivo como o seu tamanho: {info.Length}");

            }

            Console.WriteLine("");
            Console.WriteLine("files And Subfolder Files:  ");
            foreach (var file in filesAndSubfolderFiles)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("");

        }
    }
}

