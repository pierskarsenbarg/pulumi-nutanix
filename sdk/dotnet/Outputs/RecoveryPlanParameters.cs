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
    public sealed class RecoveryPlanParameters
    {
        public readonly ImmutableArray<Outputs.RecoveryPlanParametersFloatingIpAssignmentList> FloatingIpAssignmentLists;
        public readonly ImmutableArray<Outputs.RecoveryPlanParametersNetworkMappingList> NetworkMappingLists;

        [OutputConstructor]
        private RecoveryPlanParameters(
            ImmutableArray<Outputs.RecoveryPlanParametersFloatingIpAssignmentList> floatingIpAssignmentLists,

            ImmutableArray<Outputs.RecoveryPlanParametersNetworkMappingList> networkMappingLists)
        {
            FloatingIpAssignmentLists = floatingIpAssignmentLists;
            NetworkMappingLists = networkMappingLists;
        }
    }
}
