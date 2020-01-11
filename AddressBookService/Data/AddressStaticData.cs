using AddressBookService.Model.Database;
using System;

namespace AddressBookService.Data
{
    public static class AddressStaticData
    {
        public static readonly Address[] addresses =
           new Address[]
           {
                new Address()
                {
                    Id = Guid.Parse("74babd01-e17c-4804-9396-843682aeac7c"),
                    StreetAddress = "Test St 1",
                    City = "London",
                    Country = "England",
                    AddressBookId = Guid.Parse("384497a7-4e3b-4f91-b248-0fd250ef0b69")
                },
                new Address()
                {
                    Id = Guid.Parse("8a92a38e-5e85-488d-b20d-1d34bd8037f2"),
                    StreetAddress = "Test St 2",
                    City = "london",
                    Country = "England",
                    AddressBookId = Guid.Parse("abfb6a4f-6dd2-45f7-b712-e270f5c5ab6d")
                },
                new Address()
                {
                    Id = Guid.Parse("b0a02e8e-fb78-41d1-b35d-5658a20fc31c"),
                    StreetAddress = "Test St 3",
                    City = "New York",
                    Country = "USA",
                    AddressBookId = Guid.Parse("515f5a89-0002-437c-9cdd-a55bd31769c7")
                },
                new Address()
                {
                    Id = Guid.Parse("826d8e11-ee0d-4e99-934f-5e742ef28164"),
                    StreetAddress = "Test St 4",
                    City = "New york",
                    Country = "USA",
                    AddressBookId = Guid.Parse("1eada19b-7b8c-4b50-97a0-0322db5fc969")
                },
                new Address()
                {
                    Id = Guid.Parse("b9791e7f-4d85-437f-a0ca-cdfec73d199e"),
                    StreetAddress = "Test St 4",
                    City = "London",
                    Country = "England",
                    AddressBookId = Guid.Parse("c1aefccf-c057-4a20-a407-8b007801a9fe")
                },
                new Address()
                {
                    Id = Guid.Parse("52dbd833-fc25-482d-9ac4-73c1962074fa"),
                    StreetAddress = "1765 Long street",
                    City = "boston",
                    Country = "USA",
                    AddressBookId = Guid.Parse("9cc2ff2e-77cc-4e09-8450-2cacd84500ff")
                },
           };
    }
}
