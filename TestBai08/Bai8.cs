using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using MethodLibrary;

namespace TestBai08
{
    [TestClass]
    public class Bai8
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data08.csv", "data08#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int soCu = Convert.ToInt32(TestContext.DataRow["chiSoCu"]);
            int soMoi = Convert.ToInt32(TestContext.DataRow["chiSoMoi"]);
            double expected = Convert.ToDouble(TestContext.DataRow["rst"]);

            double result = methodLibrary.TinhTienDien(soCu, soMoi);

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
