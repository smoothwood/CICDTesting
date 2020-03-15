using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CICDTesting
{
    public class Maths
    {
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int? Divide(int x, int y)
        {
            //uncomment below code lines to make test pass during continuous integration
            if (y == 0)
            {
                return null;
            }

            return x / y;
        }
    }
}
