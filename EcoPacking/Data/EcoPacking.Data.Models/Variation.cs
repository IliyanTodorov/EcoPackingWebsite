namespace EcoPacking.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using EcoPacking.Data.Common.Models;

    public class Variation : BaseModel<int>
    {
        [Required]
        public string Name { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
