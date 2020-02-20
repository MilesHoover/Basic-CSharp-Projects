using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int callMath;
            mathOp n = new mathOp();

            Console.WriteLine("Please type a number you wish to be multiplied by 5:");
            int numberMult = Convert.ToInt32(Console.ReadLine());
            callMath = n.Mult(numberMult);
            Console.WriteLine("\n{0} * 5 = {1}", numberMult, callMath);
            
            Console.ReadLine();

            Console.WriteLine("\nPlease type a number you wish to be subtracted by 5:");
            decimal numberSub = Convert.ToDecimal(Console.ReadLine());
            callMath = n.Mult(numberSub);
            Console.WriteLine("\n{0} - 5 = {1}", numberSub, callMath);

            Console.ReadLine();

            Console.WriteLine("\nPlease type a number you wish to have 5 added to:");
            string numberString = Console.ReadLine();
            callMath = n.Mult(numberString);
            Console.WriteLine("\n{0} + 5 = {1}", numberString, callMath);

            Console.ReadLine();
        }
    }
}
