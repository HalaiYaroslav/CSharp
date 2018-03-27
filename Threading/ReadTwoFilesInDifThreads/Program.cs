using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadTwoFilesInDifThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            IOManager firstFile = new IOManager(@"D:\Fahrenheit.txt");
            IOManager secondFile = new IOManager(@"D:\Test.txt");

            Thread[] threadsOfReadingFiles = {new Thread(firstFile.Read), new Thread(secondFile.Read)};
            Thread[] threadsOfWritingFiles = {new Thread(firstFile.Write), new Thread(secondFile.Write)};

            foreach (Thread thread in threadsOfReadingFiles)
            {
                thread.Start();
                thread.Join();
            }

            foreach (Thread thread in threadsOfWritingFiles)
            {
                thread.Start();
            }

            Console.ReadKey();
        }
    }
}
