using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1Mahima.Controllers
{
    public class HelloWorldController : ApiController
    { 
        public string Get(int id)
        {
            return "Hello World!";
        }
    }
}
    
