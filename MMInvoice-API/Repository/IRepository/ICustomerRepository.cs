using MMInvoice_API.Models.Dto;

namespace MMInvoice_API.Repository.IRepository
{
    public interface ICustomerRepository
    {
        Task<List<GetCustomerDetailsDto>> GetCustomerSummaryDtoAsync();

        Task AddCustomerAsync(AddCustomerDto customer);
    }
}
