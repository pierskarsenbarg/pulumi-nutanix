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
    public sealed class RecoveryPlanParametersNetworkMappingList
    {
        public readonly bool? AreNetworksStretched;
        public readonly ImmutableArray<Outputs.RecoveryPlanParametersNetworkMappingListAvailabilityZoneNetworkMappingList> AvailabilityZoneNetworkMappingLists;

        [OutputConstructor]
        private RecoveryPlanParametersNetworkMappingList(
            bool? areNetworksStretched,

            ImmutableArray<Outputs.RecoveryPlanParametersNetworkMappingListAvailabilityZoneNetworkMappingList> availabilityZoneNetworkMappingLists)
        {
            AreNetworksStretched = areNetworksStretched;
            AvailabilityZoneNetworkMappingLists = availabilityZoneNetworkMappingLists;
        }
    }
}
