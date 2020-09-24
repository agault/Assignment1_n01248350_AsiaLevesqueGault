using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
 /// <summary>
    /// My way of tackleing this question was 
    /// coming at it as basic math. 
    /// We need variables as place holders.
    /// My logic:
    /// 
    /// 
    /// X = # FortNights
    /// 1 FN = 5.50
    /// {id} = # Days
    /// HST = 0.13
    /// 
    /// X={id}/14 <- Number of Fortnights, Rounded to nearest integer.
    /// (X)5.50 + 5.50<-price of service before tax
    /// HST*((X)5.50) <- tax cost
    /// ((X)5.50)+ (HST*((X)5.5)) <-total cost
    /// 
    ///  // GET api/bonus
    /// //Test changes to push to github
/// </summary>
/// <results>
    ///As of right now it outputs an integer fairly close to the true value but clearly rounded not a decimal.
///</results>
namespace Assignment1_n01248350_AsiaLevesqueGault.Controllers
{
    public class BonusController : ApiController
    {
        public IEnumerable<int> Get(int id)
        {
            int X = id / 14;//X is the number of FN
            int BeforeTax = X *(550 / 100) + (550/100);//Number of FN * my attempt at a decimal
            int HST = BeforeTax * (13 / 100);//Price B4 tax * 0.13
            int Total = HST + BeforeTax;//Price B4 tax + Tax
            return new int[] {Total};//Attempt at total
        }

    }
}
