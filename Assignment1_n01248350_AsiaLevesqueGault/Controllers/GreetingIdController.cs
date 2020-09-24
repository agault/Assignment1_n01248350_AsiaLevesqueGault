using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01248350_AsiaLevesqueGault.Controllers
{/// <summary>
    ///  GET api/greetingid
    ///  This uses a function that returns a string and an int.
/// </summary>
/// <returns>
    /// Returns Greeting to string + id + people. Not on the same line howevers
/// </returns>
    public class GreetingIdController : ApiController
    {
        // GET api/greetingid
        public IEnumerable<string> Get(string id)
        {
            return new string[] { "Greetings to", id, "people!" };
        }
    }
}
