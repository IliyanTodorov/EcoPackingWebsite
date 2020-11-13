namespace EcoPacking.Data.Models
{
    public class CustomerOrder
    {
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
