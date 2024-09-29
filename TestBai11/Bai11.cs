using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace TestBai11
{
    [TestClass]
    public class Bai11
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data11.csv", "data11#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            String s1 = TestContext.DataRow["s1"].ToString();
            String s2 = TestContext.DataRow["s2"].ToString();
            String s3 = TestContext.DataRow["s3"].ToString();
            String expected = TestContext.DataRow["rst"].ToString();

            String result = methodLibrary.ThayThe(s1, s2, s3);

            Assert.AreEqual(expected, result);

        }
    }
}
