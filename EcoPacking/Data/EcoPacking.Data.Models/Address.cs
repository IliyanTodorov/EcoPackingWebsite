namespace EcoPacking.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using EcoPacking.Data.Common.Models;

    public class Address : BaseDeletableModel<int>
    {
        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string LastName { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required]
        public string City { get; set; }

        public string State { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
