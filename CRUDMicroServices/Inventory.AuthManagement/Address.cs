namespace Inventory.AuthManagement
{

    public class Address
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public string? PostalCode { get; set; }
        public required string Country { get; set; }
    }

}
