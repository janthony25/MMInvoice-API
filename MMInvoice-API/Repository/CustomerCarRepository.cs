using Microsoft.EntityFrameworkCore;
using MMInvoice_API.Data;
using MMInvoice_API.Models.Dto;
using MMInvoice_API.Models.Entity;
using MMInvoice_API.Repository.IRepository;

namespace MMInvoice_API.Repository
{
    public class CustomerCarRepository : ICustomerCarRepository
    {
        private readonly ApplicationDbContext _context;
        public CustomerCarRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<CustomerCarListDto>> GetCustomerCarDetailsAsync()
        {
            var customerCarDetail = await _context.tblCar
                 .Include(car => car.tblCustomer)
                 .Include(car => car.tblCarManufacturer)
                     .ThenInclude(cm => cm.tblCarMake)
                 .Select(customer => new CustomerCarListDto
                 {
                     CustomerId = customer.CustomerId,
                     CustomerName = customer.tblCustomer.CustomerName,
                     CarRego = customer.CarRego,
                     CarMake = customer.tblCarManufacturer.Select(cm => cm.tblCarMake.CarMakeName).FirstOrDefault(),
                     CarModel = customer.CarModel
                 }).ToListAsync();

            return customerCarDetail;
        }
    }
}
