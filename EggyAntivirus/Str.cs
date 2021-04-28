using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggyAntivirus
{
    class Str
    {
        public struct HelpItem
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Usage { get; set; }
            public HelpItem(string Name, string Description, string Usage)
            {
                this.Name = Name;
                this.Description = Description;
                this.Usage = Usage;
            }
        }
    }
}
