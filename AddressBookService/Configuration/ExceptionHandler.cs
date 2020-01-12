using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace AddressBookService.Configuration
{
    public class ExceptionHandler
    {
        private readonly RequestDelegate _next;
        private readonly ITelemetryTracker _telemetryTracker;

        public ExceptionHandler(
            RequestDelegate next,
            ITelemetryTracker telemetryTracker)
        {
            _next = next;
            _telemetryTracker = telemetryTracker;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                await HandleException(context, exception);
                _telemetryTracker.TrackException(exception);
            }
        }

        private async Task HandleException(HttpContext context, Exception exception)
        {
            switch (exception)
            {
                default:
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    await CreateResponseMessage(context, exception.Message);
                    break;
            }
        }

        private async Task CreateResponseMessage(HttpContext context, string message) =>
            await context.Response.WriteAsync(
                JsonConvert.SerializeObject(new { message }));
    }
}
