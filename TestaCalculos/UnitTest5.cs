using System;
using Calculos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestaCalculos
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestaRaiz5()
        {
            Class5Root raiz = new Class5Root();
            raiz.CalculaRaiz(10);
            raiz.CalculaRaiz(11);
            raiz.CalculaRaiz(12);
            raiz.CalculaRaiz(13);
            raiz.CalculaRaiz(14);
            raiz.CalculaRaiz(15);

        }
    }
}
