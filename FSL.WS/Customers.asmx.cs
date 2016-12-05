using FSL.WS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace FSL.WS
{
    /// <summary>
    /// Summary description for Customer
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Customers : System.Web.Services.WebService
    {
        [WebMethod]
        public List<Customer> GetAllCustomers()
        {
            return new List<Customer>()
            {
                new Customer() { Id = "1", Name = "Customer 1" },
                new Customer() { Id = "2", Name = "Customer 2" },
                new Customer() { Id = "3", Name = "Customer 3" }
            };
        }
    }
}
