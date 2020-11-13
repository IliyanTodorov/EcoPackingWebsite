namespace EcoPacking.Data.Models
{
    using EcoPacking.Data.Common.Models;

    public class DiscountCode : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public int Percentage { get; set; }
    }
}
