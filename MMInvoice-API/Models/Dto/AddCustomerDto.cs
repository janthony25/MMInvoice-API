namespace MMInvoice_API.Models.Dto
{
    public class AddCustomerDto
    {
        public required string CustomerName { get; set; }
        public string? CustomerEmail { get; set; }
    }
}
