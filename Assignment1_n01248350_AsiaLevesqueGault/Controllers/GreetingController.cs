using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

/// <summary>
/// POST api/greeting
/// Spits out Hello World
/// </summary>
/// <results> "hello World!" </results>

namespace Assignment1_n01248350_AsiaLevesqueGault.Controllers
{
    public class GreetingController : ApiController
    {
        // POST api/greeting
        public IEnumerable<string> Post()
        {
           return new string[] { "Hello World!" };
        }
    }
}

