using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.Test_MSTest_
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void sendName()
        {
            String expected = "FRSummit";
            String s1 = "FR";
            String s2 = "Summit";
            String actual = WebApplication1.ClassLibrary.Person.sendName(s1, s2);
            Assert.AreEqual(expected, actual);

            String s3 = " Summit";
            String actualFalse = WebApplication1.ClassLibrary.Person.sendName(s1, s3);
            Assert.AreNotEqual(expected, actualFalse);
        }
    }
}
