using System;
using System.Collections.Generic;
using System.Linq;

using System.Web.Http;
using theapi.Models;

namespace theapi.Controllers
{
    public class HelloController : ApiController
    {
        public string GetHello()
        {
            test testHello = new test();
            return (testHello.testText);
        }
    }
}