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
    public sealed class RecoveryPlanParametersFloatingIpAssignmentListVmIpAssignmentListVmNicInformation
    {
        public readonly string? Ip;
        /// <summary>
        /// (Required) the UUID.
        /// </summary>
        public readonly string Uuid;

        [OutputConstructor]
        private RecoveryPlanParametersFloatingIpAssignmentListVmIpAssignmentListVmNicInformation(
            string? ip,

            string uuid)
        {
            Ip = ip;
            Uuid = uuid;
        }
    }
}
