using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace TestBai09
{
    [TestClass]
    public class Bai9
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data09.csv", "data09#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long s0 = Convert.ToInt64(TestContext.DataRow["s0"]);
            long Expected_k = Convert.ToInt64(TestContext.DataRow["k"]);
            long expected_S = Convert.ToInt64(TestContext.DataRow["s"]);

            long actual = methodLibrary.Sum(s0, out long s);

            Assert.AreEqual(Expected_k, actual);
            Assert.AreEqual(expected_S, s);
            
        }
    }
}
