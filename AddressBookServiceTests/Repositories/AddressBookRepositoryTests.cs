using AddressBookService.Data;
using AddressBookService.Model.Database;
using AddressBookService.Repository;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AddressBookServiceTests.Repositories
{
    public class AddressBookRepositoryTests
    {
        private readonly IAddressBookRepository _addressBookRepository;
        private readonly DbContextOptions<AddressBookDbContext> _dbContextOptions;

        public AddressBookRepositoryTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<AddressBookDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var dbContext = new AddressBookDbContext(_dbContextOptions);

            _addressBookRepository = new AddressBookRepository(dbContext);
        }

        [Fact(DisplayName = "" +
            "GIVEN a list is returned with ungrouped address books " +
            "WHEN getting grouped adddress books " +
            "THEN the grouped list is returned")]
        public async Task GetGroupdAddressBooks_ListIsNotGrouped_ReturnsGroupedList()
        {
            var addressBooks = new List<AddressBook>()
            {
                new AddressBook
                {
                    FirstName = "FN1",
                    LastName = "LN1",
                    Address = new Address
                    {
                        City = "City 1",
                        Country = "Country 1",
                        StreetAddress = "SA 1"
                    }
                },
                new AddressBook
                {
                    FirstName = "FN2",
                    LastName = "LN2",
                    Address = new Address
                    {
                        City = "City 2",
                        Country = "Country 2",
                        StreetAddress = "SA 1"
                    }
                },
                new AddressBook
                {
                    FirstName = "FN3",
                    LastName = "LN3",
                    Address = new Address
                    {
                        City = "City 1",
                        Country = "Country 1",
                        StreetAddress = "SA 3"
                    }
                }
            };

            using (var context = new AddressBookDbContext(_dbContextOptions))
            {
                context.AddressBooks.AddRange(addressBooks);
                await context.SaveChangesAsync();
            }

            var result = await _addressBookRepository.GetGroupedAddressBooks();

            result.ElementAt(0).City.Should().Be(result.ElementAt(1).City);
        }
    }
}
