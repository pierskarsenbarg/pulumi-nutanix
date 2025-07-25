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
    public sealed class GetVpcsEntityResult
    {
        /// <summary>
        /// - The vpc kind metadata.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Metadata;
        /// <summary>
        /// VPC input spec
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVpcsEntitySpecResult> Specs;
        /// <summary>
        /// VPC output status
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVpcsEntityStatusResult> Statuses;

        [OutputConstructor]
        private GetVpcsEntityResult(
            ImmutableDictionary<string, string> metadata,

            ImmutableArray<Outputs.GetVpcsEntitySpecResult> specs,

            ImmutableArray<Outputs.GetVpcsEntityStatusResult> statuses)
        {
            Metadata = metadata;
            Specs = specs;
            Statuses = statuses;
        }
    }
}
