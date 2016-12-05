using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSL.XF2.Models
{
    public interface ICustomerSoapService
    {
        Task<List<ICustomer>> GetAllCustomers(string criteria = null);
    }
}
