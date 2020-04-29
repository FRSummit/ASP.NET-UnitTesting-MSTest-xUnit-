using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class TestController : Controller
    {
        public String Index()
        {
            return "Test";
        }
    }
}