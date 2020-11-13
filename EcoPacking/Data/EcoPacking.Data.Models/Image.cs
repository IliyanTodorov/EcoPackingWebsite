namespace EcoPacking.Data.Models
{
    using EcoPacking.Data.Common.Models;

    public class Image : BaseDeletableModel<int>
    {
        public string Extention { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
