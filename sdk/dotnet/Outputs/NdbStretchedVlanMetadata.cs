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
    public sealed class NdbStretchedVlanMetadata
    {
        public readonly string? Gateway;
        public readonly string? SubnetMask;

        [OutputConstructor]
        private NdbStretchedVlanMetadata(
            string? gateway,

            string? subnetMask)
        {
            Gateway = gateway;
            SubnetMask = subnetMask;
        }
    }
}
