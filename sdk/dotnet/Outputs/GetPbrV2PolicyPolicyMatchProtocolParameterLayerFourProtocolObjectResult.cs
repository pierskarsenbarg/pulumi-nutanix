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
    public sealed class GetPbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectResult
    {
        /// <summary>
        /// Start and end port ranges object.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectDestinationPortRangeResult> DestinationPortRanges;
        /// <summary>
        /// Start and end port ranges object.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectSourcePortRangeResult> SourcePortRanges;

        [OutputConstructor]
        private GetPbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectResult(
            ImmutableArray<Outputs.GetPbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectDestinationPortRangeResult> destinationPortRanges,

            ImmutableArray<Outputs.GetPbrV2PolicyPolicyMatchProtocolParameterLayerFourProtocolObjectSourcePortRangeResult> sourcePortRanges)
        {
            DestinationPortRanges = destinationPortRanges;
            SourcePortRanges = sourcePortRanges;
        }
    }
}
