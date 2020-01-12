using AddressBookService.Model.Database;
using AddressBookService.Model.View;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookService.Factories
{
    public static class AddressBookFactory
    {
        public static IEnumerable<AddressBookView> BuildViewFromDataModel(IEnumerable<AddressBook> addressBooks)
        {
            return addressBooks.Select(ab => 
            {
                return new AddressBookView
                {
                    FirstName = ab.FirstName,
                    LastName = ab.LastName,
                    City = ab.Address.City,
                    Country = ab.Address.Country,
                    StreetAddress = ab.Address.StreetAddress
                };
            });
        }

        public static IEnumerable<AddressBookView> BuildGroupedViewsByCity(IEnumerable<AddressBook> addressBooks)
        {
            return addressBooks.GroupBy(ab => ab.Address.City).SelectMany(group =>
            {
                return group.Select(g => 
                {
                    return new AddressBookView
                    {
                        FirstName = g.FirstName,
                        LastName = g.LastName,
                        StreetAddress = g.Address.StreetAddress,
                        City = g.Address.City,
                        Country = g.Address.Country,
                    };
                });
            });
        }
    }
}
