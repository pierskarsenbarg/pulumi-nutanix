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
    public sealed class GetRecoveryPlanParameterNetworkMappingListAvailabilityZoneNetworkMappingListRecoveryIpAssignmentListResult
    {
        public readonly ImmutableArray<Outputs.GetRecoveryPlanParameterNetworkMappingListAvailabilityZoneNetworkMappingListRecoveryIpAssignmentListIpConfigListResult> IpConfigLists;
        public readonly Outputs.GetRecoveryPlanParameterNetworkMappingListAvailabilityZoneNetworkMappingListRecoveryIpAssignmentListVmReferenceResult VmReference;

        [OutputConstructor]
        private GetRecoveryPlanParameterNetworkMappingListAvailabilityZoneNetworkMappingListRecoveryIpAssignmentListResult(
            ImmutableArray<Outputs.GetRecoveryPlanParameterNetworkMappingListAvailabilityZoneNetworkMappingListRecoveryIpAssignmentListIpConfigListResult> ipConfigLists,

            Outputs.GetRecoveryPlanParameterNetworkMappingListAvailabilityZoneNetworkMappingListRecoveryIpAssignmentListVmReferenceResult vmReference)
        {
            IpConfigLists = ipConfigLists;
            VmReference = vmReference;
        }
    }
}
