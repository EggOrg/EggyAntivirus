using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggyAntivirus
{
    class Register
    {
        public static List<Str.HelpItem> helps { get; set; }
        public static void RegisterCommand(Str.HelpItem he)
        {
            helps.Add(he);
        }
    }
}
