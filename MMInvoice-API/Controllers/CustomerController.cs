using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMInvoice_API.Models.Dto;
using MMInvoice_API.Repository.IRepository;

namespace MMInvoice_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet("customer")]
        public async Task<IActionResult> GetCustomers()
        {
            var customerList = await _customerRepository.GetCustomerSummaryDtoAsync();
            return Ok(customerList);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewCustomer(AddCustomerDto customerDto)
        {
           await _customerRepository.AddCustomerAsync(customerDto);
            return Ok();
        }
    }
}
