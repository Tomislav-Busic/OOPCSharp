using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp
{
    public class PingIPV4
    {
        public int HostAddress { get; set; }
        public int DestAddress { get; set; }
        public string Data { get; set; }

        // If ping boots, return true but SAME
        public bool Init()
        {
            return true;
        }
        // Different implementation
        public bool SendPing()
        {
            return true;
        }
    }
}
