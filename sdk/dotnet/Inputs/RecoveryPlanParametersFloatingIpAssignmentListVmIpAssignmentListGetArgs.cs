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

    public sealed class RecoveryPlanParametersFloatingIpAssignmentListVmIpAssignmentListGetArgs : Pulumi.ResourceArgs
    {
        [Input("recoveryFloatingIpConfig")]
        public Input<Inputs.RecoveryPlanParametersFloatingIpAssignmentListVmIpAssignmentListRecoveryFloatingIpConfigGetArgs>? RecoveryFloatingIpConfig { get; set; }

        [Input("testFloatingIpConfig")]
        public Input<Inputs.RecoveryPlanParametersFloatingIpAssignmentListVmIpAssignmentListTestFloatingIpConfigGetArgs>? TestFloatingIpConfig { get; set; }

        [Input("vmNicInformation", required: true)]
        public Input<Inputs.RecoveryPlanParametersFloatingIpAssignmentListVmIpAssignmentListVmNicInformationGetArgs> VmNicInformation { get; set; } = null!;

        [Input("vmReference", required: true)]
        public Input<Inputs.RecoveryPlanParametersFloatingIpAssignmentListVmIpAssignmentListVmReferenceGetArgs> VmReference { get; set; } = null!;

        public RecoveryPlanParametersFloatingIpAssignmentListVmIpAssignmentListGetArgs()
        {
        }
    }
}