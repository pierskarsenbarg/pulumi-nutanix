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
    public sealed class GetPcRestorePointV2DomainManagerNetworkInternalNetworksIpRangeResult
    {
        /// <summary>
        /// - The beginning IP address of the range.
        /// </summary>
        public readonly Outputs.GetPcRestorePointV2DomainManagerNetworkInternalNetworksIpRangeBeginResult Begin;
        /// <summary>
        /// - The ending IP address of the range.
        /// </summary>
        public readonly Outputs.GetPcRestorePointV2DomainManagerNetworkInternalNetworksIpRangeEndResult End;

        [OutputConstructor]
        private GetPcRestorePointV2DomainManagerNetworkInternalNetworksIpRangeResult(
            Outputs.GetPcRestorePointV2DomainManagerNetworkInternalNetworksIpRangeBeginResult begin,

            Outputs.GetPcRestorePointV2DomainManagerNetworkInternalNetworksIpRangeEndResult end)
        {
            Begin = begin;
            End = end;
        }
    }
}
