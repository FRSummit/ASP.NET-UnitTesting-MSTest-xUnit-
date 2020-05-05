using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace WebApplication1.Test
{
    public class PersonTest
    {
        private readonly ITestOutputHelper output;
        public PersonTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void sendName()
        {
            String expected = "FRSummit";
            String s1 = "FR";
            String s2 = "Summit";
            String actual = WebApplication1.ClassLibrary.Person.sendName(s1, s2);
            Assert.Equal(expected, actual);

            String s3 = " Summit";
            String actualFalse = WebApplication1.ClassLibrary.Person.sendName(s1, s3);
            output.WriteLine("This is output", actualFalse);
            Assert.NotEqual(expected, actualFalse);
        }
    }
}
