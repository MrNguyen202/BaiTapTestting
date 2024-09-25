using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace TestBai04
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "data#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int input = Convert.ToInt32(TestContext.DataRow["n"]);
            bool expected = Convert.ToBoolean(TestContext.DataRow["rct"]);
            bool result = methodLibrary.IsLeapYear(input);
            Assert.AreEqual(expected, result);
        }
    }
}
