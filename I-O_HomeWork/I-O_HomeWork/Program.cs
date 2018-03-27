using System;
using System.IO;

namespace I_O_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create a file. Write into it some information then read its content to console.
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();

            Console.WriteLine("Enter path to file:");
            string path = Console.ReadLine();

            FileInfo file = new FileInfo($@"{path}\{fileName}.txt");
            StreamWriter writer = file.CreateText();

            Console.WriteLine("Enter some information:");
            string output = Console.ReadLine();

            writer.Write(output);

            writer.Close();
            Console.WriteLine("\nFile created. Informatin was wrote.");

            StreamReader reader = File.OpenText($@"{path}\{fileName}.txt");

            Console.WriteLine("File content:");

            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }

            reader.Close();
            #endregion

            Console.ReadKey();
        }
    }
}
