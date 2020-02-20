using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    class mathOp
    {
        public int Mult(int numberMult)
        {
            int multProd = numberMult * 5;
            return multProd;
        }

        public int Mult(decimal numberSub)
        {
            decimal subProd = numberSub - 5;
            int intProd = Convert.ToInt32(subProd);
            return intProd;
        }

        public int Mult(string numberString)
        {
            int stringCon = Convert.ToInt32(numberString);
            int addProd = stringCon + 5;
            return addProd;
        }
    }
}
