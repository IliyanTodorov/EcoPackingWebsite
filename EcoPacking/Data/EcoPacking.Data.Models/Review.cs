namespace EcoPacking.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using EcoPacking.Data.Common.Models;

    public class Review : BaseDeletableModel<int>
    {
        public DateTime WrittenOn { get; set; }

        [Required]
        [MinLength(12)]
        public string Description { get; set; }

        public int Rating { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Required]
        [ForeignKey(nameof(Author))]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }
    }
}
