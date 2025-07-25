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
    public sealed class GetPcRestorePointV2DomainManagerNetworkExternalNetworkIpRangeResult
    {
        /// <summary>
        /// - The beginning IP address of the range.
        /// </summary>
        public readonly Outputs.GetPcRestorePointV2DomainManagerNetworkExternalNetworkIpRangeBeginResult Begin;
        /// <summary>
        /// - The ending IP address of the range.
        /// </summary>
        public readonly Outputs.GetPcRestorePointV2DomainManagerNetworkExternalNetworkIpRangeEndResult End;

        [OutputConstructor]
        private GetPcRestorePointV2DomainManagerNetworkExternalNetworkIpRangeResult(
            Outputs.GetPcRestorePointV2DomainManagerNetworkExternalNetworkIpRangeBeginResult begin,

            Outputs.GetPcRestorePointV2DomainManagerNetworkExternalNetworkIpRangeEndResult end)
        {
            Begin = begin;
            End = end;
        }
    }
}
