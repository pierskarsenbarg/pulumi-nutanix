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
    public sealed class GetRecoveryPlanParameterFloatingIpAssignmentListVmIpAssignmentListTestFloatingIpConfigResult
    {
        public readonly string Ip;
        public readonly bool ShouldAllocateDynamically;

        [OutputConstructor]
        private GetRecoveryPlanParameterFloatingIpAssignmentListVmIpAssignmentListTestFloatingIpConfigResult(
            string ip,

            bool shouldAllocateDynamically)
        {
            Ip = ip;
            ShouldAllocateDynamically = shouldAllocateDynamically;
        }
    }
}
