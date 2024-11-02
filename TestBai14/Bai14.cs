using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace TestBai14
{
    [TestClass]
    public class Bai14
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataBai14.csv", "DataBai14#csv", DataAccessMethod.Sequential)]
        public void TestMethodData()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            //Lấy mảng từ file csv arr = "1,2,3,4,5"
            int[] list = Array.ConvertAll(TestContext.DataRow[0].ToString().Split(','), int.Parse);
            int left = int.Parse(TestContext.DataRow[1].ToString());
            int right = int.Parse(TestContext.DataRow[2].ToString());
            int[] list_ect = Array.ConvertAll(TestContext.DataRow[3].ToString().Split(','), int.Parse);

            methodLibrary.QuickSort(list, left, right);

            CollectionAssert.AreEqual(list_ect, list);
        }
    }
}
