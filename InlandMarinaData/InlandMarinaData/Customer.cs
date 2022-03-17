using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InlandMarinaData
{
	[Table("Customer")]
	public class Customer
	{
		public int ID { get; set; }

		[Required]
		[StringLength(30)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(30)]
		public string LastName { get; set; }

		[Required]
		[StringLength(15)]
		[RegularExpression("^([0-9]{3}-[0-9]{3}-[0-9]{4})$", ErrorMessage ="Phone number must follow this format: 111-111-1111")]
		public string Phone { get; set; }

		[Required]
		[StringLength(30)]
		public string City { get; set; }

		[Required]
		[StringLength(30)]
		public string Username { get; set; }

		[Required]
		[StringLength(30)]
		public string Password { get; set; }

		// navigation property
		public virtual ICollection<Lease> Leases { get; set; }
	}
}
