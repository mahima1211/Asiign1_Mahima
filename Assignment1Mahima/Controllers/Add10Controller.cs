using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1Mahima.Controllers
{
    public class Add10Controller : ApiController
    {
        //method
        //input is a number
        //output is the same number plus 10

        public int Get(int id)
        {
            int product = id + 10;
            return product;
        }
    }
}
   
