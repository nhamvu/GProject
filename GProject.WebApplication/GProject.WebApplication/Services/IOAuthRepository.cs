using GProject.Data.Context;
using GProject.Data.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace GProject.WebApplication.Services
{
    public interface IOAuthRepository
    {
        Task<Customer> GetCustomerByGoogleIdAsync(string googleId);
        Task AddCustomerAsync(Customer customer);
    }

    public class OAuthRepository : IOAuthRepository
    {
        private readonly GProjectContext _context;

        public OAuthRepository(GProjectContext context)
        {
            _context = context;
        }

        public async Task<Customer> GetCustomerByGoogleIdAsync(string googleId)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c.GoogleId == googleId);
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }
    }
}
