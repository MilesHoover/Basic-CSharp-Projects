using System;

namespace Classes_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 n = new Class1();

            Console.WriteLine("Please type a number to be multiplied by 5.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease type another number to be displayed on screen.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            n.numOp(num1, num2);

            Console.ReadLine();
        }
    }
}
