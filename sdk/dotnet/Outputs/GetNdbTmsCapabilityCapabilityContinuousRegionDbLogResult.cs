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
    public sealed class GetNdbTmsCapabilityCapabilityContinuousRegionDbLogResult
    {
        public readonly string DatabaseId;
        public readonly string DatabaseNodeId;
        public readonly string DateCreated;
        public readonly string DateModified;
        public readonly string EraLogDriveId;
        public readonly string FromTime;
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetNdbTmsCapabilityCapabilityContinuousRegionDbLogInfoResult> Infos;
        public readonly string LogCopyOperationId;
        public readonly string Message;
        public readonly ImmutableArray<Outputs.GetNdbTmsCapabilityCapabilityContinuousRegionDbLogMetadataResult> Metadatas;
        public readonly string Name;
        public readonly string OwnerId;
        public readonly int Size;
        public readonly string Status;
        public readonly string ToTime;
        public readonly bool Unprocessed;

        [OutputConstructor]
        private GetNdbTmsCapabilityCapabilityContinuousRegionDbLogResult(
            string databaseId,

            string databaseNodeId,

            string dateCreated,

            string dateModified,

            string eraLogDriveId,

            string fromTime,

            string id,

            ImmutableArray<Outputs.GetNdbTmsCapabilityCapabilityContinuousRegionDbLogInfoResult> infos,

            string logCopyOperationId,

            string message,

            ImmutableArray<Outputs.GetNdbTmsCapabilityCapabilityContinuousRegionDbLogMetadataResult> metadatas,

            string name,

            string ownerId,

            int size,

            string status,

            string toTime,

            bool unprocessed)
        {
            DatabaseId = databaseId;
            DatabaseNodeId = databaseNodeId;
            DateCreated = dateCreated;
            DateModified = dateModified;
            EraLogDriveId = eraLogDriveId;
            FromTime = fromTime;
            Id = id;
            Infos = infos;
            LogCopyOperationId = logCopyOperationId;
            Message = message;
            Metadatas = metadatas;
            Name = name;
            OwnerId = ownerId;
            Size = size;
            Status = status;
            ToTime = toTime;
            Unprocessed = unprocessed;
        }
    }
}
