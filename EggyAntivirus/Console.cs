using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggyAntivirus
{
    class Console
    {
        public static void WriteLine(string line)
        {
            System.Console.WriteLine(string.Format("{0," + System.Console.WindowWidth / 2 + "}", line));
        }
    }
}
