using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace dotnet_fileNdirectory_manipulation
{
    class ReadWriteFile
    {
        public void Exec()
        {

            // get path file 
            string filePath = @"C:\temp\demo\teste.txt";

            //string[] lines = File.ReadAllLines(filePath);

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList(); // converte array para lista


            // Inclui registro 
            lines.Add("Pessoa1, SobrenomePessoa1, www.site.com.br");

            foreach (String line in lines)
            {
                Console.WriteLine(line);
            }


            Console.ReadLine();

        }
    }
}

