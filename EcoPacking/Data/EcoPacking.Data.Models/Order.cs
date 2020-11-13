namespace EcoPacking.Data.Models
{
    using System;

    using EcoPacking.Data.Common.Models;

    public class Order : BaseDeletableModel<int>
    {
        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ShipDate { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public int ShippingAddressId { get; set; }

        public ShippingAddress ShippingAddress { get; set; }
    }
}
