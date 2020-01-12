using AddressBookService.Data;
using AddressBookService.Factories;
using AddressBookService.Model.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            throw new Exception("Random exception");

            var result = await _context.AddressBooks.ToListAsync();

            return AddressBookFactory.BuildGroupedViewsByCity(result);
        }
    }
}
