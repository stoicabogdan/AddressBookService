using AddressBookService.Model.View;
using AddressBookService.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookService.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {
        private readonly IAddressBookRepository _addressbookRepository;

        public AddressBookController(IAddressBookRepository addressBookRepository)
        {
            _addressbookRepository = addressBookRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddressBookView>>> GetAddressBooks()
        {
            var result = await _addressbookRepository.GetGroupedAddressBooks();

            if (!result.Any())
                return NotFound();

            return Ok(result);
        }
    }
}