using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnlyOneProjectCanWork
{
    class Program
    {
        private static readonly Semaphore semaphore = new Semaphore(2, 4);
        private static bool existed;
        static string guid = Marshal.GetTypeLibGuidForAssembly(Assembly.GetExecutingAssembly()).ToString();
        static Mutex mutexObj = new Mutex(true, guid, out existed);

        static void Main(string[] args)
        {
            if (existed)
            {
                Console.WriteLine("Application running.");
            }
            else
            {
                Console.WriteLine("Application had been started and will be closed after 3 seconds.");
                Thread.Sleep(3000);
                return;
            }

            Thread[] threads = {    new Thread(DoSomeWork),
                                    new Thread(DoSomeWork),
                                    new Thread(DoSomeWork),
                                    new Thread(DoSomeWork)
                                };
            
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Name = $"Thread number {i}";
                threads[i].Start();
            }
            Console.ReadKey();
        }

        static void DoSomeWork()
        {
            semaphore.WaitOne();

            var log = new LogInfoKeeper() { ThreadName = Thread.CurrentThread.Name, StartWorkTime = DateTime.Now };

            Console.WriteLine($"{Thread.CurrentThread.Name} had started his work. {DateTime.Now.TimeOfDay}");

            //some work
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} iteration[{i + 1}]");
                Thread.Sleep(500);
            }

            log.EndWorkTime = DateTime.Now;

            log.SaveLogInfo();

            Console.WriteLine($"{Thread.CurrentThread.Name} had done his work.  {DateTime.Now.TimeOfDay}\n");
            semaphore.Release();
        }
    }
}
