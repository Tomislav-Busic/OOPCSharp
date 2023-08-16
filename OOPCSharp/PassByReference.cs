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
            Square(person1, person2);
            Console.WriteLine(person1.Age + " " + person2.Age);

            void Square (Person a, Person b)
            {
                a.Age = a.Age * a.Age;
                b.Age = b.Age * b.Age;

                Console.WriteLine($"Person1: {a.Age}, Person2: {b.Age}");
            }
        }
     }
}
