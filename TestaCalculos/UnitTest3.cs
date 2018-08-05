using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculos;

namespace TestaCalculos
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestaRedeSocial()
        {
                Friend a = new Friend("A");
                Friend b = new Friend("B");
                Friend c = new Friend("C");

                a.AddFriendship(b);
                b.AddFriendship(c);

                Console.WriteLine(a.CanBeConnected(c));
        }
    }
}
