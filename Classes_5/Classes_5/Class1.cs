using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_5
{
    class Operations
    {

        public void Div(int num)
        {
            int quotient = num / 2;
            Console.WriteLine("{0} / 2 = {1}", num, quotient);
        }

        public void Greeting()
        {
            Console.WriteLine("\nHello, World! The method that produced this text took no parameters");
        }

        public int stringOrInt(int numMult)
        {
            int product = numMult * 5;
            return product;
        }

        public string stringOrInt(string name)
        {
            string greet = "Hello, " + name;
            return greet;
        }

        public static void withoutObj()
        {
            Console.WriteLine("Hello");
        }
    }
}
