using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HGD.PersonAlgorithm.Test.Collection
{
    [TestClass]
    public class To_Test
    {
        [TestMethod]
        public void To__0_start_5_end__return__01234()
        {
            var start = 0;
            var end = 5;

            var target = start.To(end);

            Assert.AreEqual(5, target.Count());
            Assert.AreEqual(0, target.ElementAt(0));
            Assert.AreEqual(1, target.ElementAt(1));
            Assert.AreEqual(2, target.ElementAt(2));
            Assert.AreEqual(3, target.ElementAt(3));
            Assert.AreEqual(4, target.ElementAt(4));
        }
    }
}
