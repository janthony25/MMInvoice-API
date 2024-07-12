using Microsoft.EntityFrameworkCore;
using MMInvoice_API.Data;
using MMInvoice_API.Models.Dto;
using MMInvoice_API.Models.Entity;
using MMInvoice_API.Repository.IRepository;

namespace MMInvoice_API.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddCustomerAsync(AddCustomerDto customerDto)
        {
            var customer = new tblCustomer
            {
                CustomerName = customerDto.CustomerName,
                CustomerEmail = customerDto.CustomerEmail
            };

            _context.tblCustomer.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<GetCustomerDetailsDto>> GetCustomerSummaryDtoAsync()
        {
            return await _context.tblCustomer
                .Select(c => new GetCustomerDetailsDto
                {
                    CustomerId = c.CustomerId,
                    CustomerName = c.CustomerName,
                    CustomerEmail = c.CustomerEmail,
                }).ToListAsync();
        }
    }
}
