using Microsoft.Extensions.Logging;
using SaleAnchor.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleAnchor.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CustomerDetails_Create(CustomerDetailsModel custDetails)
        {
            _context.Add(custDetails);
        }

        public void CustomerDetails_Update(CustomerDetailsModel custDetails)
        {
            _context.Update(custDetails);
        }

        public CustomerDetailsModel CustomerDetails_GET(string custId)
        {
            return _context.CustomerDetails
                .Where(t => t.AspUserId == custId)
                .FirstOrDefault();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
