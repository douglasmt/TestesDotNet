using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public class Class4
    {
        public int commonDivisor(int a, int b)
        {
            int commonDivisorIs = 0;
            int remainderIs = 0;
            if (a > b)
            {
                if (b == 0)
                {
                    commonDivisorIs = a;
                }
                else
                {

                    commonDivisorIs = a % b;

                }
            } else
            {
                if (a == 0)
                {
                    commonDivisorIs = b;
                }
                else
                {
                    commonDivisorIs = b % a;

                }
            }
            return commonDivisorIs;
        }
    }
}
