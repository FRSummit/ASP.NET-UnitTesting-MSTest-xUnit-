using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.Test_MSTest_
{
    [TestClass]
    public class ComparatorTest
    {
        [TestMethod]
        public void ValueComparatorTest()
        {
            int expected = 10;
            int num1 = 15;
            int num2 = 5;
            int actual = WebApplication1.ClassLibrary.Comparator.ValueComparator(num1, num2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringComparatorTest()
        {
            String s1 = "FRSummit";
            String s2 = "FRSummit";
            bool actual = WebApplication1.ClassLibrary.Comparator.StringComparator(s1, s2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void StringComparatorTest2()
        {
            String s1 = "FRSummit";
            String s2 = "Summit";
            bool actual = WebApplication1.ClassLibrary.Comparator.StringComparator(s1, s2);
            Assert.IsFalse(actual);
        }
    }
}
