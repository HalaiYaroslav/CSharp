extern alias CL;
using CL::MyNamespace;
using System;
using System.Collections.Generic;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1. MyNamespace           
            //MyClass myClass = new MyClass();
            //myClass.Method();
            #endregion

            #region Task 2. MyDictionary
            //MyDictionary<string, string> fullNames = new MyDictionary<string, string>();
            //fullNames.Add("Yaroslav", "Halai");
            //fullNames.Add("Karina", "Pogorilenko");

            //var names = new string[] { "Anton", "Natasha" };
            //var sureNames = new string[] { "Puchko", "Mihaylishyn" };

            //fullNames.Add(names, sureNames);

            //fullNames.Add("Andriy", "Yuschenko");
            //fullNames.Add("Dasha", "Krasunya");

            //int counter = 0;
            //foreach (var item in fullNames)
            //{
            //    if (counter == 2)
            //    {
            //        counter = 0;
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine(item);
            //    counter++;
            //}
            #endregion

            #region Task 3. Outstanding method
            //InheritedClass iClass = new InheritedClass();
            //iClass.Method();
            #endregion

            Console.ReadKey();
        }
    }
}
