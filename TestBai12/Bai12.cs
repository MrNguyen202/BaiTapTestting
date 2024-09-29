using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace TestBai12
{
    [TestClass]
    public class Bai12
    {
        [TestMethod] // Test case 1
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = { 2, 3, 4, 5 };

            int ex = 5;

            int result = methodLibrary.Largest(a);

            Assert.AreEqual(ex, result);
        }

        [TestMethod] // Test case 3
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[0];

            int ex = int.MaxValue;

            int result = methodLibrary.Largest(a);

            Assert.AreEqual(ex, result);
        }

        [TestMethod] // Test case 4
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = { 2, 3, 4, 2147483647 };
            
            int ex = int.MaxValue;

            int result = methodLibrary.Largest(a);

            Assert.AreEqual(ex, result);
        }

        [TestMethod] // Test case 5
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = { -2147483647, -2147483647 };
;

            int ex = int.MinValue;

            int result = methodLibrary.Largest(a);

            Assert.AreEqual(ex, result);
        }

    }
}
