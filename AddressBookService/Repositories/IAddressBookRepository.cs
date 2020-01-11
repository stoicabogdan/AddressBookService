using AddressBookService.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookService.Repository
{
    public interface IAddressBookRepository
    {
        Task<IEnumerable<AddressBookView>> GetAddressBooks();
    }
}
