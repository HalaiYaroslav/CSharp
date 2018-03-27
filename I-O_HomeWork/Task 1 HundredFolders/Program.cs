using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_HundredFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path:");
            string path = Console.ReadLine();
            DirectoryInfo directory = new DirectoryInfo(path);

            if (directory.Exists)
            {
                for (int i = 0; i < 100; i++)
                {

                    directory.CreateSubdirectory(path + $@"\Folder_{i + 1}");
                }
            }

            foreach (var folder in directory.EnumerateDirectories())
            {
                Console.Write(folder.Name + "\t");
            }

            Console.WriteLine("\nDo you want to delete all this files? (Yes/No)");
            bool answer = Console.ReadLine().ToLower() == "yes" ? true : false;

            if (answer)
            {
                for (int i = 0; i < 100; i++)
                {
                    Directory.Delete($"Folder_{i + 1}");
                }
                Console.WriteLine("Directories were deleted.");
            }

            Console.ReadKey();
        }
    }
}
