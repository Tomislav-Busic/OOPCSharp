using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp
{
    public class Dog : IDogWalker
    {
        public void WalkToTheCity()
        {
            Console.WriteLine("Walk to the city.");
        }

        public void WalkToTheFoodBowl()
        {
            Console.WriteLine("Walk to the foodbowl.");
        }

        public void WalkToThePark()
        {
            Console.WriteLine("Walk to the park.");
        }
    }
}
