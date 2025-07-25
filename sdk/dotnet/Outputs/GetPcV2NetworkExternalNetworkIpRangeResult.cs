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
    public sealed class GetPcV2NetworkExternalNetworkIpRangeResult
    {
        /// <summary>
        /// - The beginning IP address of the range.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPcV2NetworkExternalNetworkIpRangeBeginResult> Begins;
        /// <summary>
        /// - The ending IP address of the range.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPcV2NetworkExternalNetworkIpRangeEndResult> Ends;

        [OutputConstructor]
        private GetPcV2NetworkExternalNetworkIpRangeResult(
            ImmutableArray<Outputs.GetPcV2NetworkExternalNetworkIpRangeBeginResult> begins,

            ImmutableArray<Outputs.GetPcV2NetworkExternalNetworkIpRangeEndResult> ends)
        {
            Begins = begins;
            Ends = ends;
        }
    }
}
