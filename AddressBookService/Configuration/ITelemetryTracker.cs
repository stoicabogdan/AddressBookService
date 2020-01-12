using System;
using System.Collections.Generic;

namespace AddressBookService.Configuration
{
    public interface ITelemetryTracker
    {
        void TrackException(Exception exception);
        void TrackEvent(string eventName, IDictionary<string, string> properties = null, IDictionary<string, double> metrics = null);
    }
}
