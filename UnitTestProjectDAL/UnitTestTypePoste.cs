using System;
using DALJobChannel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectDAL
{
    [TestClass]
    public class UnitTestTypePoste
    {
        [TestMethod]
        public void TestGetAllTypePoste()
        {
            DALTypePoste getAllTypePoste = new DALTypePoste();
            var f = getAllTypePoste.GetAllTypePostes();
            Assert.IsTrue(f.Count != 0);
        }
    }
}
