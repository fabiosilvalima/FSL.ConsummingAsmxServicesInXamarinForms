using System.Collections.Generic;
using FSL.XF2.Models;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(FSL.XF2.Droid.CustomerSoapService))]
namespace FSL.XF2.Droid
{
    public sealed class CustomerSoapService : ICustomerSoapService
    {
        CustomersWs.Customers service;

        public CustomerSoapService()
        {
            service = new CustomersWs.Customers()
            {
                Url = "http://10.0.2.2/FSL.WS/Customers.asmx"
            };
        }

        public async Task<List<ICustomer>> GetAllCustomers(string criteria = null)
        {
            return await Task.Run(() =>
            {
                var result = service.GetAllCustomers();

                return new List<ICustomer>(result);
            });
        }
    }
}