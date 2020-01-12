using AddressBookService.Configuration;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AddressBookServiceTests.Configuration
{
    public class ExceptionHandlerTests
    {
        private readonly Mock<RequestDelegate> _requestDelegate;
        private readonly Mock<ITelemetryTracker> _telemetryTracker;
        private readonly ExceptionHandler _exceptionHandler;
        private readonly HttpContext _httpContext;

        public ExceptionHandlerTests()
        {
            _requestDelegate = new Mock<RequestDelegate>();
            _telemetryTracker = new Mock<ITelemetryTracker>();
            _exceptionHandler = new ExceptionHandler(_requestDelegate.Object, _telemetryTracker.Object);
            _httpContext = new DefaultHttpContext();
        }

        [Fact(DisplayName = "GIVEN exception is thrown WHEN invoke is called THEN track and set 500 status code")]
        public async Task Invoke_ExceptionIsThrown_ThenTrackAndSetStatusCode()
        {
            _requestDelegate.Setup(rd => rd(It.IsAny<HttpContext>())).Throws(new Exception("Error Message"));

            await _exceptionHandler.Invoke(_httpContext);

            _httpContext.Response.StatusCode.Should().Be(StatusCodes.Status500InternalServerError);
            _telemetryTracker.Verify(t => t.TrackException(It.IsAny<Exception>()), Times.Once);
        }
    }
}
