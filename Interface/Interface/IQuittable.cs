using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IQuittable
    {
        void Quit() //Feature 'default interface implementation' is not available in C# 7.3. Please use language version 8.0 or greater.
        {
            Console.WriteLine("The program will now exit");
        }

    }
}
