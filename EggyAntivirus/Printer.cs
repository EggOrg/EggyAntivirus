using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggyAntivirus
{
    class Printer
    {
        public static void MakeDivider(string div)
        {
            System.Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"----===--- -<[ {div} ]>- ---===----");
            System.Console.ResetColor();
        }

        public static void PrintError(string err)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(err);
            System.Console.ResetColor();
        }

        public static void PrintInfo(string inf)
        {
            System.Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(inf);
            System.Console.ResetColor();
        }

        public static void PrintUnsafe(int num)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Unsafe files: {num}");
            System.Console.ResetColor();
        }

        public static void PrintUnknown(int num)
        {
            System.Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Unknown files: {num}");
            System.Console.ResetColor();
        }

        public static void PrintSafe(int num)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Safe files: {num}");
            System.Console.ResetColor();
        }

        public static void ListUnsafeFiles(List<string> unsafefiles)
        {
            System.Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (string unsafefile in unsafefiles)
            {
                Console.WriteLine($"- Unsafe file: {unsafefile}");
            }
            System.Console.ResetColor();
        }

        public static void ListUnknown(List<string> unknownfiles)
        {
            System.Console.ForegroundColor = ConsoleColor.DarkGray;
            foreach (string unknownfile in unknownfiles)
            {
                Console.WriteLine($"- Unknown file: {unknownfile}");
            }
            System.Console.ResetColor();
        }

        public static void LiveListUnsafeFile(string unsafefile)
        {
            System.Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"- Unsafe file: {unsafefile}");
            System.Console.ResetColor();
        }
    }
}
