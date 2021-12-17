using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopMethods
{
    public static class MathUtils
    {
        public static int Fact(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Fact(n - 1);
        }
    }
}
