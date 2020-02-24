using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_5
{
    public static class Operations
    {

        public static void Div(int num)
        {
            int quotient = num / 2;
            Console.WriteLine("{0} / 2 = {1}", num, quotient);
        }

        public static void Greeting()
        {
            Console.WriteLine("\nHello, World! The method that produced this text took no parameters");
        }

        public static int stringOrInt(int numMult)
        {
            int product = numMult * 5;
            return product;
        }

        public static string stringOrInt(string name)
        {
            string greet = "Hello, " + name;
            return greet;
        }

    }
}
