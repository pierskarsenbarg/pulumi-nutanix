// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Outputs
{

    [OutputType]
    public sealed class GetNdbTmsCapabilityCapabilityContinuousRegionResult
    {
        public readonly ImmutableArray<Outputs.GetNdbTmsCapabilityCapabilityContinuousRegionDbLogResult> DbLogs;
        public readonly string FromTime;
        public readonly string Message;
        public readonly bool PartialRanges;
        public readonly ImmutableArray<Outputs.GetNdbTmsCapabilityCapabilityContinuousRegionProcessedRangeResult> ProcessedRanges;
        public readonly ImmutableArray<string> SnapshotIds;
        public readonly string Snapshots;
        public readonly bool SubRange;
        public readonly string TimeRangeAndDatabases;
        public readonly string Timezone;
        public readonly string ToTime;
        public readonly string UnknownTimeRanges;
        public readonly ImmutableArray<Outputs.GetNdbTmsCapabilityCapabilityContinuousRegionUnprocessedRangeResult> UnprocessedRanges;

        [OutputConstructor]
        private GetNdbTmsCapabilityCapabilityContinuousRegionResult(
            ImmutableArray<Outputs.GetNdbTmsCapabilityCapabilityContinuousRegionDbLogResult> dbLogs,

            string fromTime,

            string message,

            bool partialRanges,

            ImmutableArray<Outputs.GetNdbTmsCapabilityCapabilityContinuousRegionProcessedRangeResult> processedRanges,

            ImmutableArray<string> snapshotIds,

            string snapshots,

            bool subRange,

            string timeRangeAndDatabases,

            string timezone,

            string toTime,

            string unknownTimeRanges,

            ImmutableArray<Outputs.GetNdbTmsCapabilityCapabilityContinuousRegionUnprocessedRangeResult> unprocessedRanges)
        {
            DbLogs = dbLogs;
            FromTime = fromTime;
            Message = message;
            PartialRanges = partialRanges;
            ProcessedRanges = processedRanges;
            SnapshotIds = snapshotIds;
            Snapshots = snapshots;
            SubRange = subRange;
            TimeRangeAndDatabases = timeRangeAndDatabases;
            Timezone = timezone;
            ToTime = toTime;
            UnknownTimeRanges = unknownTimeRanges;
            UnprocessedRanges = unprocessedRanges;
        }
    }
}
