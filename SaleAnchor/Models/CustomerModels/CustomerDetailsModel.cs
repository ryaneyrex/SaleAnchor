using System;

namespace SaleAnchor.Models
{
    public class CustomerDetailsModel
    {
        public string Id { get; set; }
        public string AspUserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DoB { get; set; }
        public bool EmailUpdates { get; set; }
    }
}
