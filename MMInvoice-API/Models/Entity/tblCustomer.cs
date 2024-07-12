using System.ComponentModel.DataAnnotations;

namespace MMInvoice_API.Models.Entity
{
    public class tblCustomer
    {
        [Key]
        public int CustomerId { get; set; }
        public required string CustomerName { get; set; }
        public string? CustomerEmail { get; set; }
        public string? PaymentStatus { get; set; }
        public ICollection<tblCar>? tblCar { get; set; }
    }
}
