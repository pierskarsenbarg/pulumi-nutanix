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

    public sealed class RecoveryPlanStageListArgs : Pulumi.ResourceArgs
    {
        [Input("delayTimeSecs")]
        public Input<int>? DelayTimeSecs { get; set; }

        [Input("stageUuid")]
        public Input<string>? StageUuid { get; set; }

        [Input("stageWork", required: true)]
        public Input<Inputs.RecoveryPlanStageListStageWorkArgs> StageWork { get; set; } = null!;

        public RecoveryPlanStageListArgs()
        {
        }
    }
}