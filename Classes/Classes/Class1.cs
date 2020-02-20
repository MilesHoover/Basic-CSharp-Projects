using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Operations
    {
        public int OperationAdd(int intAdd)
        {
            int sum = intAdd + 50;
            return sum;
        }

        public int OperationSub(int intSub)
        {
            int dif = intSub - 50;
            return dif;
        }

        public int OperationMult(int intMult)
        {
            int prod = intMult * 50;
            return prod;
        }
    }
}
