using AddressBookService.Model.Database;
using System;

namespace AddressBookService.Data
{
    public static class AddressBookStaticData
    {
        public static readonly AddressBook[] addressBooks =
           new AddressBook[]
           {
               new AddressBook()
               {
                   Id = Guid.Parse("384497a7-4e3b-4f91-b248-0fd250ef0b69"),
                   FirstName = "John",
                   LastName = "Smith",
               },
               new AddressBook()
               {
                   Id = Guid.Parse("abfb6a4f-6dd2-45f7-b712-e270f5c5ab6d"),
                   FirstName = "Jane",
                   LastName = "Doe",
               },
               new AddressBook()
               {
                   Id = Guid.Parse("515f5a89-0002-437c-9cdd-a55bd31769c7"),
                   FirstName = "Tim",
                   LastName = "Jones",
               },
               new AddressBook()
               {
                   Id = Guid.Parse("1eada19b-7b8c-4b50-97a0-0322db5fc969"),
                   FirstName = "David",
                   LastName = "Jones",
               },
               new AddressBook()
               {
                   Id = Guid.Parse("c1aefccf-c057-4a20-a407-8b007801a9fe"),
                   FirstName = "Any",
                   LastName = "Body",
               },
               new AddressBook()
               {
                   Id = Guid.Parse("9cc2ff2e-77cc-4e09-8450-2cacd84500ff"),
                   FirstName = "Any",
                   LastName = "Body",
               },
           };
    }
}
