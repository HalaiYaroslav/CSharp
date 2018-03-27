using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadTwoFilesInDifThreads
{
    class IOManager
    {
        #region Private members
        string path;
        StreamReader fileReader;
        FileInfo file;
        StringBuilder fileContent = new StringBuilder();
        static readonly object locker = new object();
        #endregion

        public IOManager(string path)
        {
            this.path = path;

            file = new FileInfo(this.path);
            fileReader = new StreamReader(this.path);
        }

        public void Read()
        {
            ConsoleConfigurator.YellowForeColor();
            Console.WriteLine($"The file {file.Name} opened.");

            ConsoleConfigurator.GreenForeColor();
            Console.WriteLine("Reading the file:");

            ConsoleConfigurator.GreenBackgroundWhiteForeColors();
            fileContent.AppendLine(file.Name);
            while (!fileReader.EndOfStream)
            {
                StringBuilder line = new StringBuilder();
                line.AppendLine(fileReader.ReadLine());
                fileContent.Append(line);
                Console.WriteLine(line);
            }

            ConsoleConfigurator.DefaultConsoleColors();
            Console.WriteLine("File just had readed.\n");

            ConsoleConfigurator.DefaultConsoleColors();
            fileReader.Close();
        }

        public void Write()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Writing content of \"{file.Name}\" file.");

            lock (locker)
            {
                var writer = new StreamWriter(@"D:\ConcatenationOfTwoFiles.txt", true);
                writer.Write(fileContent);
                writer.Close();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Content of \"{file.Name}\" had written.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
