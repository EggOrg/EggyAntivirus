using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EggyAntivirus.Scanner;

namespace EggyAntivirus
{
    class Methods
    {
        public static int count = 0;

        public static void Process(string path)
        {
            ScanFile(path);
        }

        public static void ListFile(string path)
        {
            Console.WriteLine($"- {path}");
        }

        public static void CountFile(string path)
        {
            count++;
        }
    }
}
