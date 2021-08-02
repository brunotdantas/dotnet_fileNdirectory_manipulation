using System;
using System.IO;

namespace dotnet_fileNdirectory_manipulation
{
    class Directories
    {
        public void Exec(string rootPath)
        {

            // checa se diretório existe e se não cria o diretório

            if (!Directory.Exists(rootPath))
            {
                Console.WriteLine($"O diretório '{rootPath}' Não existe. Criando o diretório ...");

                // porém não é necessário checar antes de criar, se rodarmos esse método e já existir, nao acontece nada
                Directory.CreateDirectory(rootPath);

            }

            // Ler pastas no caminho desejado
            string[] dirs = Directory.GetDirectories(rootPath);

            // ler pastas e subpastas
            string[] dirs2 = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

            foreach (string directory in dirs)
            {
                Console.WriteLine(directory);
            }

            foreach (string directory in dirs2)
            {
                Console.WriteLine(directory);
            }





        }
    }
}

