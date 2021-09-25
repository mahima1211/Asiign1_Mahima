using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1Mahima.Controllers
{
    public class SquareController : ApiController
    {
        //method
        //input is a number
        //output is the same number multiplied by the same number

        public int Get(int id)
        {
            int product = id * id;
            return product;
        }
    }
}
   
