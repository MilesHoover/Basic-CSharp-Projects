using System;
using System.Collections.Generic;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> divList = new List<int>();
            divList.Add(2);
            divList.Add(4);
            divList.Add(8);
            divList.Add(16);
            try
            {
                Console.WriteLine("Type a number you want to divide by:");
                int divNum = Convert.ToInt32(Console.ReadLine());

                foreach (int num in divList)
                {
                    int result = num / divNum;
                    Console.WriteLine(result);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.ReadLine();
            }

            Console.WriteLine("\nThe program has emerged from the try/catch block.");
            Console.ReadLine();

        }
    }
}
