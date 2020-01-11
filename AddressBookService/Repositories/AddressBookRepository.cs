using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBookService.Model.View;

namespace AddressBookService.Repository
{
    public class AddressBookRepository: IAddressBookRepository
    {
        public AddressBookRepository()
        {

        }

        public Task<IEnumerable<AddressBookView>> GetAddressBooks()
        {
            throw new NotImplementedException();
        }
    }
}
