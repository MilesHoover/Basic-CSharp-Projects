using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3
{
    class MathOp
    {
        public int Mult(int num1, int num2 = 0)
        {
            int numTotal = num1 + num2;
            int prod = numTotal * 5;
            return prod;
        }
    }
}
