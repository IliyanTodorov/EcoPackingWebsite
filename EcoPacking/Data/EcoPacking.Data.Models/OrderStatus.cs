namespace EcoPacking.Data.Models
{
    using EcoPacking.Data.Common.Models;

    public class OrderStatus : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}
