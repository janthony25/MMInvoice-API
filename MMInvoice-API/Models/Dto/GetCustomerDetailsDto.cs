namespace MMInvoice_API.Models.Dto
{
    public class GetCustomerDetailsDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string? CustomerEmail { get; set; }
    }
}
