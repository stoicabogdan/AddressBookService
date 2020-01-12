using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;

namespace AddressBookService.Configuration
{
    public class TelemetryTracker : ITelemetryTracker
    {
        private readonly TelemetryClient _telemetryClient;

        public TelemetryTracker(TelemetryClient telemetryClient)
        {
            _telemetryClient = telemetryClient;
        }

        public void TrackException(Exception exception) => _telemetryClient.TrackException(exception);
        public void TrackEvent(string eventName, IDictionary<string, string> properties = null, IDictionary<string, double> metrics = null)
            => _telemetryClient.TrackEvent(eventName, properties, metrics);
    }
}
