using System;
using Calculos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestaCalculos
{
    [TestClass]
    public class UnitTest1
    {
        Class1 classeTeste = new Class1();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, classeTeste.Somar(2, 4));
        }
    }
}
