using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

/// <summary>
    /// The square of 2 numbers is themselves multiplied
    /// GET api/square
/// </summary>
/// <result> 
    /// id*id.
/// </result>
namespace Assignment1_n01248350_AsiaLevesqueGault.Controllers
{
    public class SquareController : ApiController
    {
        // GET api/square
        public int Get(int id)
        {
            return (id * id);
        }
    }
}

