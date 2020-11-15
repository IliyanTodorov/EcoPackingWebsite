namespace EcoPacking.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using EcoPacking.Data.Common.Models;

    public class Image : BaseDeletableModel<int>
    {
        [Required]
        public string Extention { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [ForeignKey(nameof(Product))]
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
