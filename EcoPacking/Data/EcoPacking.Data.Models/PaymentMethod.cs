namespace EcoPacking.Data.Models
{
    using EcoPacking.Data.Common.Models;

    public class PaymentMethod : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}
