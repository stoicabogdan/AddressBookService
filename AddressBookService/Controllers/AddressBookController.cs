using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBookService.Model.View;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddressBookService.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddressBookView>>> GetAddressBooks()
        {
            return Ok(Enumerable.Empty<AddressBookView>());
        }
    }
}