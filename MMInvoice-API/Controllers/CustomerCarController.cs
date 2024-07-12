using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMInvoice_API.Repository.IRepository;

namespace MMInvoice_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerCarController : ControllerBase
    {
        private readonly ICustomerCarRepository _customerCarRepository;
        public CustomerCarController(ICustomerCarRepository customerCarRepository)
        {
            _customerCarRepository = customerCarRepository;
        }

        [HttpGet("customerCar")]
        public async Task<IActionResult> GetCustomerCarDetails()
        {
            var customerCar = await _customerCarRepository.GetCustomerCarDetailsAsync();
            return Ok(customerCar);
        }
    }
}
