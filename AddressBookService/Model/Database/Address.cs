using System;

namespace AddressBookService.Model.Database
{
    public class Address
    {
        public Guid Id { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
