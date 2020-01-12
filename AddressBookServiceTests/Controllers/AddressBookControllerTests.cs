using AddressBookService.Controller;
using AddressBookService.Model.View;
using AddressBookService.Repository;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AddressBookServiceTests.Controllers
{
    public class AddressBookControllerTests
    {
        private readonly Mock<IAddressBookRepository> _addressBookRepository;
        private readonly AddressBookController _addressBookController;

        public AddressBookControllerTests()
        {
            _addressBookRepository = new Mock<IAddressBookRepository>();
            _addressBookController = new AddressBookController(_addressBookRepository.Object);
        }

        [Fact(DisplayName = "GIVEN address books exist WHEN getting address books THEN an ok result is returned")]
        public async Task GetAddressBooks_AddressBooksExist_ReturnOkObjectResult()
        {
            _addressBookRepository.Setup(repo => repo.GetGroupedAddressBooks())
                .ReturnsAsync(
                    new List<AddressBookView>()
                    {
                        new AddressBookView()
                    });

            var result = await _addressBookController.GetAddressBooks();

            result.Result.Should().BeOfType<OkObjectResult>();
        }

        [Fact(DisplayName = "GIVEN address books do not exist WHEN getting address books THEN a not found result is returned")]
        public async Task GetAddressBooks_AddressBooksDoNotExist_ReturnNotFoundResult()
        {
            _addressBookRepository.Setup(repo => repo.GetGroupedAddressBooks())
                .ReturnsAsync(new List<AddressBookView>());

            var result = await _addressBookController.GetAddressBooks();

            result.Result.Should().BeOfType<NotFoundResult>();
        }
    }
}
