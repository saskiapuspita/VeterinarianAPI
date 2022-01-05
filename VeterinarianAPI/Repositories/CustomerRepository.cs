using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinarianAPI.Models;

namespace VeterinarianAPI.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Customer> Create(Customer customer)
        {
            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        public async Task Delete(int id)
        {
            var customerToDelete = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customerToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> Get()
        {
            return await _context.Customer.ToListAsync();
        }

        public async Task<Customer> Get(int id)
        {
            return await _context.Customer.FindAsync(id);
        }

        public async Task Update(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
