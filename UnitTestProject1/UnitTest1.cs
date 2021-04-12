using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondMax;

namespace NUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 2, 1, 0, 3, 8, 9, 2, 1, 10 };
            int expected = 9;

            int actual = Test.FoundMax2nd(array);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestMethod2()
        {
            int[] array = null;
            int actual = Test.FoundMax2nd(array);
        }
    }
}