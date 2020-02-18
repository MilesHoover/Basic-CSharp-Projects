using System;

namespace While_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old is the author of this program?\n");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 21;

            do
            {
                switch (number)
                {
                    case 21:
                        Console.WriteLine("\nThat was correct! I am 21 years old.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("\nYou are incorrect, try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.Read();
        }
    }
}
