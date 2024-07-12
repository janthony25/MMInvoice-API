using System.ComponentModel.DataAnnotations;

namespace MMInvoice_API.Models.Entity
{
    public class tblCar
    {
        [Key]
        public int CarId { get; set; }
        public required string CarRego { get; set; }
        public string? CarModel { get; set; }

        // tblCustomer
        public int CustomerId { get; set; }
        public tblCustomer? tblCustomer { get; set; }

        // many-to-many CarMake
        public ICollection<tblCarManufacturer>? tblCarManufacturer { get; set; }


    }
}
