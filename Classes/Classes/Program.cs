using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations n = new Operations();

            Console.WriteLine("What number would you like added by 50?\n");
            int intAdd = Convert.ToInt32(Console.ReadLine());
            int sum = n.OperationAdd(intAdd);
            Console.WriteLine("The sum is: " + sum);

            Console.WriteLine("\nWhat number would you like subtracted by 50?\n");
            int intSub = Convert.ToInt32(Console.ReadLine());
            int dif = n.OperationSub(intSub);
            Console.WriteLine("The difference is: " + dif);

            Console.WriteLine("\nWhat number would you like multiplied by 50?\n");
            int intMult = Convert.ToInt32(Console.ReadLine());
            int prod = n.OperationMult(intMult);
            Console.WriteLine("The product is: " + prod);

            Console.ReadLine();
        }
    }
}
