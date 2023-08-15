using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp
{
    internal class PingIPV6 : BasePing
    {
        // Different implementation
        public bool SendPing()
        {
            return true;
        }
    }
}
