using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    public class Integers
    {
        public int myMethod(int x)
        {
            int result = x / 2;
            return result;
        }
        public int myMethod(decimal x)
        {
            decimal result = x * 2;
            int final = Convert.ToInt32(result);
            return final;
        }
        public int myMethod(string x)
        {

            int result = Convert.ToInt32(x);
            result = result + 3;
            return result;
        }
    }
}
