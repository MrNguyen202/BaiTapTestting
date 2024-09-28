using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace TestBai03
{
    [TestClass]
    public class Bai3
    {
        [TestMethod] // Test case 1
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.primeCheck(3);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // Test case 2 có ExpectedException
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.primeCheck(1);
            bool expected = false;
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // Test case 3
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.primeCheck(4);
            bool expected = false;
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // Test case 4
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.primeCheck(9);
            bool expected = false;
            Assert.AreEqual(expected, result);
        }

        //[TestMethod] // test case throw an exception
        //public void TestMethod5()
        //{
        //    MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
        //    var expected = Assert.ThrowsException<ArgumentNullException>(() => methodLibrary.primeCheck('hai'));
        //    Assert.AreEqual("Giá trị truyền vào phải là số nguyên", expected.Message);
        //}

        [TestMethod] // Test case 8
        public void TestMethod8()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.primeCheck(3);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // Test case 9
        public void TestMethod9()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.primeCheck(5);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // Test case 11
        public void TestMethod11()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.primeCheck(0);
            bool expected = false;
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // Test case 12
        public void TestMethod12()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.primeCheck(1000);
            bool expected = false;
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // Test case 13
        public void TestMethod13()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.primeCheck(2);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }
        [TestMethod] // Test case 16
        public void TestMethod16()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            bool result = methodLibrary.primeCheck(1);
            bool expected = false;
            Assert.AreEqual(expected, result);
        }
    }
}
