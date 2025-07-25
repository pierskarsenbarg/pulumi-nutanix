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
    public sealed class VirtualMachineV2AvailabilityZone
    {
        /// <summary>
        /// The globally unique identifier of an availability zone type UUID.
        /// </summary>
        public readonly string? ExtId;

        [OutputConstructor]
        private VirtualMachineV2AvailabilityZone(string? extId)
        {
            ExtId = extId;
        }
    }
}
