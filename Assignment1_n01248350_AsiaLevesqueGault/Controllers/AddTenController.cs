using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
/// <summary>
    /// Able to add ten to any number added to url
    /// // GET api/addten/10
/// </summary>
/// <results>
    /// 10+id
/// </results>
namespace Assignment1_n01248350_AsiaLevesqueGault.Controllers
{
    public class AddTenController : ApiController
    {
        // GET api/addten/10
        public int Get(int id)
        {
            return (id + 10);
        }
    }
}
