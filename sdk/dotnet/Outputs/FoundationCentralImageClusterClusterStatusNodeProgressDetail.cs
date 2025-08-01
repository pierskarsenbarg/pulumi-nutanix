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
    public sealed class FoundationCentralImageClusterClusterStatusNodeProgressDetail
    {
        /// <summary>
        /// UUID of the node.
        /// </summary>
        public readonly string? ImagedNodeUuid;
        public readonly bool? ImagingStopped;
        public readonly bool? IntentPickedUp;
        public readonly ImmutableArray<string> MessageLists;
        public readonly double? PercentComplete;
        public readonly string? Status;

        [OutputConstructor]
        private FoundationCentralImageClusterClusterStatusNodeProgressDetail(
            string? imagedNodeUuid,

            bool? imagingStopped,

            bool? intentPickedUp,

            ImmutableArray<string> messageLists,

            double? percentComplete,

            string? status)
        {
            ImagedNodeUuid = imagedNodeUuid;
            ImagingStopped = imagingStopped;
            IntentPickedUp = intentPickedUp;
            MessageLists = messageLists;
            PercentComplete = percentComplete;
            Status = status;
        }
    }
}
