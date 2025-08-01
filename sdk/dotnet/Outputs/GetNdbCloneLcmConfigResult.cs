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
    public sealed class GetNdbCloneLcmConfigResult
    {
        public readonly ImmutableArray<Outputs.GetNdbCloneLcmConfigExpiryDetailResult> ExpiryDetails;
        public readonly ImmutableArray<Outputs.GetNdbCloneLcmConfigPostDeleteCommandResult> PostDeleteCommands;
        public readonly ImmutableArray<Outputs.GetNdbCloneLcmConfigPreDeleteCommandResult> PreDeleteCommands;
        public readonly ImmutableArray<Outputs.GetNdbCloneLcmConfigRefreshDetailResult> RefreshDetails;

        [OutputConstructor]
        private GetNdbCloneLcmConfigResult(
            ImmutableArray<Outputs.GetNdbCloneLcmConfigExpiryDetailResult> expiryDetails,

            ImmutableArray<Outputs.GetNdbCloneLcmConfigPostDeleteCommandResult> postDeleteCommands,

            ImmutableArray<Outputs.GetNdbCloneLcmConfigPreDeleteCommandResult> preDeleteCommands,

            ImmutableArray<Outputs.GetNdbCloneLcmConfigRefreshDetailResult> refreshDetails)
        {
            ExpiryDetails = expiryDetails;
            PostDeleteCommands = postDeleteCommands;
            PreDeleteCommands = preDeleteCommands;
            RefreshDetails = refreshDetails;
        }
    }
}
