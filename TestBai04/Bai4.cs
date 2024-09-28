using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace TestBai04
{
    [TestClass]
    public class Bai4
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data04.csv", "data04#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();
            int n = Convert.ToInt32(TestContext.DataRow["n"]);
            bool expected = Convert.ToBoolean(TestContext.DataRow["rct"]);

            bool result = method.IsLeapYear(n);

            Assert.AreEqual(expected, result);

        }
    }
}
