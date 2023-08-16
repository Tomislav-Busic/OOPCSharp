using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp
{
    public class PassByReference
    {
        public PassByReference() {
            // Pass By Value VS. Pass By Reference

            // Reference

            Person person1 = new();
            Person person2 = new();
            person1.Age = 5;
            person2.Age = 10;

            Console.WriteLine(person1.Age + " " + person2.Age);
        }
     }
}
