using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;
using System.Text;


namespace TestBai07
{
    [TestClass]
    public class Bai7
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data07.csv", "data07#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int a = Convert.ToInt32(TestContext.DataRow[0]);
            int b = Convert.ToInt32(TestContext.DataRow[1]);
            int c = Convert.ToInt32(TestContext.DataRow[2]);
            String expected = TestContext.DataRow[3].ToString();
            float Expected_X1 = float.Parse(TestContext.DataRow[4].ToString()); ;
            float Expected_X2 = float.Parse(TestContext.DataRow[5].ToString()); ;

            String SolveQuadratic = methodLibrary.SolveQuadratic(a, b, c, out float x1, out float x2);

            byte[] utf8Bytes = Encoding.UTF8.GetBytes(SolveQuadratic);
            string ExpectedUTF8 = Encoding.UTF8.GetString(utf8Bytes);

            Console.WriteLine(SolveQuadratic);
            Console.WriteLine(ExpectedUTF8);

            Assert.AreEqual(ExpectedUTF8, SolveQuadratic);
            Assert.AreEqual(Expected_X1, x1);
            Assert.AreEqual(Expected_X2, x2);
        }
    }
}
