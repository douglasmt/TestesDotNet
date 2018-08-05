using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public class Class5Root
    {
        public double CalculaRaiz(int numero)
        {
            int number = numero;
            double root = 1;
            int i = 0;
            //The Babylonian Method for Computing Square Roots
            while (true)
            {
                i = i + 1;
                root = (number / root + root) / 2;
                if (i == number + 1) { break; }
            }

            //Output
            Console.WriteLine("Square root:{0}", root);

            return root;

        }
    }
}
