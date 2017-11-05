using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace HGD.PersonAlgorithm.Test.Splitter
{
    [TestClass]
    public class To_n_Parts_Test
    {
        [TestMethod]
        public void Give__null_collection_2_n__Return__null()
        {
            var collection = (IEnumerable<Int32>)null;

            var actual=collection.To_n_Parts(2);

            Assert.IsNull(actual);
        }
        [TestMethod]
        public void Give__123_collection_2_n__Return__null()
        {
            var collection = new Int32[] { 1, 2, 3 };

            var actual = collection.To_n_Parts(2);

            Assert.IsNull(actual);
        }
        [TestMethod]
        public void Give__1234_collection_2_n__Return__12_34()
        {
            var collection = new Int32[] { 1, 2, 3, 4 };

            var actual = collection.To_n_Parts(2);

            Assert.AreEqual(2, actual.Count());

            Assert.AreEqual(2, actual[0].Length);
            Assert.AreEqual(1, actual[0][0]);
            Assert.AreEqual(2, actual[0][1]);

            Assert.AreEqual(2, actual[1].Length);
            Assert.AreEqual(3, actual[1][0]);
            Assert.AreEqual(4, actual[1][1]);
        }
        [TestMethod]
        public void Give__123456_collection_3_n__Return__12_34_56()
        {
            var collection = new Int32[] { 1, 2, 3, 4, 5, 6 };

            var actual = collection.To_n_Parts(3);

            Assert.AreEqual(3, actual.Count());

            Assert.AreEqual(2, actual[0].Length);
            Assert.AreEqual(1, actual[0][0]);
            Assert.AreEqual(2, actual[0][1]);

            Assert.AreEqual(2, actual[1].Length);
            Assert.AreEqual(3, actual[1][0]);
            Assert.AreEqual(4, actual[1][1]);

            Assert.AreEqual(2, actual[2].Length);
            Assert.AreEqual(5, actual[2][0]);
            Assert.AreEqual(6, actual[2][1]);
        }
        [TestMethod]
        public void Give__123456_collection_2_n__Return__12_34_56()
        {
            var collection = new Int32[] { 1, 2, 3, 4, 5, 6 };

            var actual = collection.To_n_Parts(2);

            Assert.AreEqual(2, actual.Count());

            Assert.AreEqual(3, actual[0].Length);
            Assert.AreEqual(1, actual[0][0]);
            Assert.AreEqual(2, actual[0][1]);
            Assert.AreEqual(3, actual[0][2]);

            Assert.AreEqual(3, actual[0].Length);
            Assert.AreEqual(4, actual[1][0]);
            Assert.AreEqual(5, actual[1][1]);
            Assert.AreEqual(6, actual[1][2]);
        }
    }
}
