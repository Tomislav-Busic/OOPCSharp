using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp
{
    public class PingIPV4 : BasePing
    {
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
