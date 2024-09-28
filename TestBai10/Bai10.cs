using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace TestBai10
{
    [TestClass]
    public class Bai10
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data10.csv", "data10#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            String s = "abcde";
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int n = Convert.ToInt32(TestContext.DataRow["n"]);
            int p = Convert.ToInt32(TestContext.DataRow["p"]);
            String expected = TestContext.DataRow["rct"].ToString();

            String result = methodLibrary.HuyChuoi(s, n, p);
            Console.WriteLine(result);

            Assert.AreEqual(expected, result);
        }
    }
}
