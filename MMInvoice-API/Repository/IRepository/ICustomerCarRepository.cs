using MMInvoice_API.Models.Dto;

namespace MMInvoice_API.Repository.IRepository
{
    public interface ICustomerCarRepository
    {
        Task<List<CustomerCarListDto>> GetCustomerCarDetailsAsync();
    }
}
