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

    public sealed class NdbRegisterDatabaseTimeMachineInfoScheduleSnapshottimeofdayGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("hours", required: true)]
        public Input<int> Hours { get; set; } = null!;

        [Input("minutes", required: true)]
        public Input<int> Minutes { get; set; } = null!;

        [Input("seconds", required: true)]
        public Input<int> Seconds { get; set; } = null!;

        public NdbRegisterDatabaseTimeMachineInfoScheduleSnapshottimeofdayGetArgs()
        {
        }
        public static new NdbRegisterDatabaseTimeMachineInfoScheduleSnapshottimeofdayGetArgs Empty => new NdbRegisterDatabaseTimeMachineInfoScheduleSnapshottimeofdayGetArgs();
    }
}