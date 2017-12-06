using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace theapi.Models
{
    public class test
    {
        public test()
        {
            //We could be retrieving the 'Hello World' string from the database at this point
            testText = "Hello World";
        }
        public string testText { get; set; }
    }
}