using System;
using System.Collections.Generic;
using System.Text;

namespace NanoMetric
{
    public interface ITelemetry<T> : ITelemetry { }

    public interface ITelemetry
    {
        DependencyTracker Dependency(String dependencyName, string commandName);
        MetricTracker Metric(string metricName);

        MeterTracker Meter(string meterName, TimeSpan? aggregationPeriod);
    }
}
