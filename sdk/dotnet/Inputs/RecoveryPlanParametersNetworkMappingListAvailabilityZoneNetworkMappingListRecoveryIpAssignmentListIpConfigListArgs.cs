// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class RecoveryPlanParametersNetworkMappingListAvailabilityZoneNetworkMappingListRecoveryIpAssignmentListIpConfigListArgs : Pulumi.ResourceArgs
    {
        [Input("ipAddress", required: true)]
        public Input<string> IpAddress { get; set; } = null!;

        public RecoveryPlanParametersNetworkMappingListAvailabilityZoneNetworkMappingListRecoveryIpAssignmentListIpConfigListArgs()
        {
        }
    }
}