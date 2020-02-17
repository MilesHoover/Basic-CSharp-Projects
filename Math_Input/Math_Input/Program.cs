using System;

namespace Math_Input
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please type a number:");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);

            Console.WriteLine(num1 * 50);

            Console.WriteLine("Please type a number:");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);

            Console.WriteLine(num2 + 25);

            Console.WriteLine("Please type a number:");
            string number3 = Console.ReadLine();
            int num3 = Convert.ToInt32(number3);

            Console.WriteLine(num3 / 12.5);

            Console.WriteLine("Please type a number:");
            string number4 = Console.ReadLine();
            int num4 = Convert.ToInt32(number4);

            Console.WriteLine(num4 > 50);

            Console.WriteLine("Please type a number:");
            string number5 = Console.ReadLine();
            int num5 = Convert.ToInt32(number5);

            Console.WriteLine(num5 % 7);

            Console.ReadLine();
        }
    }
}
