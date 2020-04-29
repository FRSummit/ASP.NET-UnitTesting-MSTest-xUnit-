using MvcMovie.Controllers;
using System;
using Xunit;

namespace MvcMovieTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new HelloWorldController();
            controller.Index();
            Console.WriteLine("Working...............................");
        }
    }
}
