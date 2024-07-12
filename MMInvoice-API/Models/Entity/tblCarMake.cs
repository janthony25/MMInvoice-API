using System.ComponentModel.DataAnnotations;

namespace MMInvoice_API.Models.Entity
{
    public class tblCarMake
    {
        [Key]
        public int CarMakeId { get; set; }
        public required string CarMakeName { get; set; }
        public ICollection<tblCarManufacturer>? tblCarManufacturer { get; set; }
    }
}
