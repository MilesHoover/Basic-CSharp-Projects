using System;

namespace Classes_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type an integer to be divided by 2:");
            int num = Convert.ToInt32(Console.ReadLine());
            Operations.Div(num);

            Console.ReadLine();

            Operations.Greeting();

            Console.ReadLine();

            Console.WriteLine("Please type an integer to be multiplied by 5:");
            int numMult = Convert.ToInt32(Console.ReadLine());
            int callMult;
            callMult = Operations.stringOrInt(numMult);
            Console.WriteLine(callMult);

            Console.ReadLine();

            Console.WriteLine("Please type a name: ");
            string nameGreet = Console.ReadLine();
            string callGreet;
            callGreet = Operations.stringOrInt(nameGreet);
            Console.WriteLine(callGreet);

            Console.ReadLine();

        }
    }
}
