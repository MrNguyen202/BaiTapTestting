using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace TestBai13
{
    [TestClass]
    public class Bai13
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataBai13.csv", "DataBai13#csv", DataAccessMethod.Sequential)]
        public void TestMethodData()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            //Lấy mảng từ file csv arr = "1,2,3,4,5"
            int[] a = Array.ConvertAll(TestContext.DataRow[0].ToString().Split(','), int.Parse);
            int n = int.Parse(TestContext.DataRow[1].ToString());
            bool ex = bool.Parse(TestContext.DataRow[2].ToString());

            bool result = methodLibrary.IsSymmetry(a, n);

            Assert.AreEqual(ex, result);
        }
    }
}
