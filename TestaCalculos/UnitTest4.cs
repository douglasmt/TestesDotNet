using System;
using Calculos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestaCalculos
{
    [TestClass]
    public class UnitTest4
    {

        [TestMethod]
        public void TestMethod1()
        {
            Class4 classeDivisor = new Class4();
            Console.WriteLine("\nResultado 2, 4:" + classeDivisor.commonDivisor(2, 4));
            Console.WriteLine("\nResultado 10, 5:" + classeDivisor.commonDivisor(10, 5));
            Console.WriteLine("\nResultado 21, 13:" + classeDivisor.commonDivisor(21, 13));
            Console.WriteLine("\nResultado 100, 100 :" + classeDivisor.commonDivisor(100, 100));
            Console.WriteLine("\nResultado 969, 741:" + classeDivisor.commonDivisor(969, 741));
        }
    }
}
