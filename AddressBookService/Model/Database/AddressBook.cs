using System;

namespace AddressBookService.Model.Database
{
    public class AddressBook
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    }
}
