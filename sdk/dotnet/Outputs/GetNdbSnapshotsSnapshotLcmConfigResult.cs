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
    public sealed class GetNdbSnapshotsSnapshotLcmConfigResult
    {
        public readonly ImmutableArray<Outputs.GetNdbSnapshotsSnapshotLcmConfigExpiryDetailResult> ExpiryDetails;
        public readonly ImmutableArray<Outputs.GetNdbSnapshotsSnapshotLcmConfigPostDeleteCommandResult> PostDeleteCommands;
        public readonly ImmutableArray<Outputs.GetNdbSnapshotsSnapshotLcmConfigPreDeleteCommandResult> PreDeleteCommands;
        public readonly ImmutableArray<Outputs.GetNdbSnapshotsSnapshotLcmConfigRefreshDetailResult> RefreshDetails;

        [OutputConstructor]
        private GetNdbSnapshotsSnapshotLcmConfigResult(
            ImmutableArray<Outputs.GetNdbSnapshotsSnapshotLcmConfigExpiryDetailResult> expiryDetails,

            ImmutableArray<Outputs.GetNdbSnapshotsSnapshotLcmConfigPostDeleteCommandResult> postDeleteCommands,

            ImmutableArray<Outputs.GetNdbSnapshotsSnapshotLcmConfigPreDeleteCommandResult> preDeleteCommands,

            ImmutableArray<Outputs.GetNdbSnapshotsSnapshotLcmConfigRefreshDetailResult> refreshDetails)
        {
            ExpiryDetails = expiryDetails;
            PostDeleteCommands = postDeleteCommands;
            PreDeleteCommands = preDeleteCommands;
            RefreshDetails = refreshDetails;
        }
    }
}
