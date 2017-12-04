using SaleAnchor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaleAnchor.Data
{
    public interface ICustomerRepository
    {
        void CustomerDetails_Create(CustomerDetailsModel custDetails);

        void CustomerDetails_Update(CustomerDetailsModel custDetails);

        CustomerDetailsModel CustomerDetails_GET(string custId);

        Task<bool> SaveChangesAsync();
    }
}