// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class GetRecoveryPlansEntityParameterNetworkMappingListResult
    {
        public readonly bool AreNetworksStretched;
        public readonly ImmutableArray<Outputs.GetRecoveryPlansEntityParameterNetworkMappingListAvailabilityZoneNetworkMappingListResult> AvailabilityZoneNetworkMappingLists;

        [OutputConstructor]
        private GetRecoveryPlansEntityParameterNetworkMappingListResult(
            bool areNetworksStretched,

            ImmutableArray<Outputs.GetRecoveryPlansEntityParameterNetworkMappingListAvailabilityZoneNetworkMappingListResult> availabilityZoneNetworkMappingLists)
        {
            AreNetworksStretched = areNetworksStretched;
            AvailabilityZoneNetworkMappingLists = availabilityZoneNetworkMappingLists;
        }
    }
}