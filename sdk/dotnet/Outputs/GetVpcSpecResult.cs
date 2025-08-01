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
    public sealed class GetVpcSpecResult
    {
        /// <summary>
        /// - the name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// VPC resources status
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVpcSpecResourceResult> Resources;

        [OutputConstructor]
        private GetVpcSpecResult(
            string name,

            ImmutableArray<Outputs.GetVpcSpecResourceResult> resources)
        {
            Name = name;
            Resources = resources;
        }
    }
}
