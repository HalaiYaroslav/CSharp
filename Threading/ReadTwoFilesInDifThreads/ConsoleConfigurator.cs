using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTwoFilesInDifThreads
{
    static class ConsoleConfigurator
    {
        public static void YellowForeColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void GreenForeColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void GreenBackgroundWhiteForeColors()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
        }

        public static void DefaultConsoleColors()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
