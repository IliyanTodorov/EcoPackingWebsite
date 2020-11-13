namespace EcoPacking.Data.Models
{
    using System;

    using EcoPacking.Data.Common.Models;

    public class Review : BaseDeletableModel<int>
    {
        public DateTime WrittenOn { get; set; }

        public string Description { get; set; }

        public int Rating { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
