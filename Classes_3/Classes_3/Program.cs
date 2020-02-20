using System;

namespace Classes_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int callMath;
            MathOp n = new MathOp();

            Console.WriteLine("Please type a number to be multiplied by 5:\n");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nWould you like to add another number to the previous number? (yes/no)\n");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("\nPlease type the second number:\n");
                int num2 = Convert.ToInt32(Console.ReadLine());
                callMath = n.Mult(num1, num2);
                Console.WriteLine("{0} + {1} * 5 = {2}", num1, num2, callMath);
            }
            else if (answer == "no")
            {
                callMath = n.Mult(num1);
                Console.WriteLine("{0} * 5 = {1}", num1, callMath);
            }
            else
            {
                Console.WriteLine("\nPlease try again and answer with either \"yes\" or \"no\"\nProgram will now close");
            }
            Console.ReadLine();
        }
    }
}
