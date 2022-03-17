using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RentalsData
{
    [Table("Renter")]
    public class Renter
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Phone { get; set; }
        //navigation property (one-to-one)
        public RentalProperty RentalProperty { get; set; }
    }
}
