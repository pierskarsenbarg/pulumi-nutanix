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
    public sealed class SelfServiceAppPatchNic
    {
        /// <summary>
        /// - (Optional, string) The index of the NIC. A dummy string for now.
        /// </summary>
        public readonly int? Index;
        /// <summary>
        /// - (Optional) The operation to perform on the category. (e.g. "add", "delete")
        /// </summary>
        public readonly string? Operation;
        /// <summary>
        /// - (Optional, string) The UUID of the subnet to which the NIC should be attached.
        /// </summary>
        public readonly string? SubnetUuid;

        [OutputConstructor]
        private SelfServiceAppPatchNic(
            int? index,

            string? operation,

            string? subnetUuid)
        {
            Index = index;
            Operation = operation;
            SubnetUuid = subnetUuid;
        }
    }
}
