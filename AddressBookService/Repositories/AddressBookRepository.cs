using AddressBookService.Data;
using AddressBookService.Model.View;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookService.Repository
{
    public class AddressBookRepository: IAddressBookRepository
    {
        private readonly AddressBookDbContext _context;
        public AddressBookRepository(AddressBookDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AddressBookView>> GetGroupedAddressBooks()
        {
            var result = await _context.AddressBooks
                .Include(ab => ab.Address)
                .ToListAsync();

            return result.ToList().OrderBy(ab => ab.Address.City.ToLower()).Select(ab => 
            {
                return new AddressBookView()
                {
                    FirstName = ab.FirstName,
                    LastName = ab.LastName,
                    City = ab.Address.City,
                    Country = ab.Address.Country,
                    StreetAddress = ab.Address.StreetAddress,
                };
            });
        }
    }
}
