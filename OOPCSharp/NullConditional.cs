using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp
{
    public class NullConditional
    {
        public NullConditional()
        {
            // NULL Conditional and Coalescing Operators

            string myString = null;

            if (myString == null)
            {
                Console.WriteLine("This string is null");
            } else
            {
                Console.WriteLine(myString);
            }

            string myString2 = null;

            Console.WriteLine(myString2 ?? "string");
        }
    }
}
