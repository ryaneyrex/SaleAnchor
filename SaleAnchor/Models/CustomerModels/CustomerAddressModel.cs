using System;

namespace SaleAnchor.Models
{
    public class CustomerAddressModel
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string PostCode { get; set; }
        public int HouseNumber { get; set; }
        public string Road { get; set; }
        public string Town { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
    }
}
