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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"----===--- -<[ {div} ]>- ---===----");
            Console.ResetColor();
        }

        public static void PrintError(string err)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(err);
            Console.ResetColor();
        }

        public static void PrintInfo(string inf)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(inf);
            Console.ResetColor();
        }

        public static void PrintUnsafe(int num)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Unsafe files: {num}");
            Console.ResetColor();
        }

        public static void PrintUnknown(int num)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Unknown files: {num}");
            Console.ResetColor();
        }

        public static void PrintSafe(int num)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Safe files: {num}");
            Console.ResetColor();
        }

        public static void ListUnsafeFiles(List<string> unsafefiles)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (string unsafefile in unsafefiles)
            {
                Console.WriteLine($"- Unsafe file: {unsafefile}");
            }
            Console.ResetColor();
        }

        public static void ListUnknown(List<string> unknownfiles)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            foreach (string unknownfile in unknownfiles)
            {
                Console.WriteLine($"- Unknown file: {unknownfile}");
            }
            Console.ResetColor();
        }

        public static void LiveListUnsafeFile(string unsafefile)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"- Unsafe file: {unsafefile}");
            Console.ResetColor();
        }
    }
}
