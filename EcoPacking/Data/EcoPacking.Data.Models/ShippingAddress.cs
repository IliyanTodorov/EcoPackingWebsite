﻿namespace EcoPacking.Data.Models
{
    using EcoPacking.Data.Common.Models;

    public class ShippingAddress : BaseDeletableModel<int>
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Street { get; set; }

        public int HouseNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string AdditionalInformation { get; set; }
    }
}
