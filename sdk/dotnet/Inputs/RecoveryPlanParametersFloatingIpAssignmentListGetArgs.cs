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

    public sealed class RecoveryPlanParametersFloatingIpAssignmentListGetArgs : Pulumi.ResourceArgs
    {
        [Input("availabilityZoneUrl", required: true)]
        public Input<string> AvailabilityZoneUrl { get; set; } = null!;

        [Input("vmIpAssignmentLists", required: true)]
        private InputList<Inputs.RecoveryPlanParametersFloatingIpAssignmentListVmIpAssignmentListGetArgs>? _vmIpAssignmentLists;
        public InputList<Inputs.RecoveryPlanParametersFloatingIpAssignmentListVmIpAssignmentListGetArgs> VmIpAssignmentLists
        {
            get => _vmIpAssignmentLists ?? (_vmIpAssignmentLists = new InputList<Inputs.RecoveryPlanParametersFloatingIpAssignmentListVmIpAssignmentListGetArgs>());
            set => _vmIpAssignmentLists = value;
        }

        public RecoveryPlanParametersFloatingIpAssignmentListGetArgs()
        {
        }
    }
}