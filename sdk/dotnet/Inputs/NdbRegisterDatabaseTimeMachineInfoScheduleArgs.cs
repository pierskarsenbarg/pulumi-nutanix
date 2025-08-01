// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class NdbRegisterDatabaseTimeMachineInfoScheduleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - (Optional) snapshot freq and log config
        /// </summary>
        [Input("continuousschedule")]
        public Input<Inputs.NdbRegisterDatabaseTimeMachineInfoScheduleContinuousscheduleArgs>? Continuousschedule { get; set; }

        /// <summary>
        /// - (Optional) monthly snapshot config
        /// </summary>
        [Input("monthlyschedule")]
        public Input<Inputs.NdbRegisterDatabaseTimeMachineInfoScheduleMonthlyscheduleArgs>? Monthlyschedule { get; set; }

        /// <summary>
        /// - (Optional) quaterly snapshot config
        /// </summary>
        [Input("quartelyschedule")]
        public Input<Inputs.NdbRegisterDatabaseTimeMachineInfoScheduleQuartelyscheduleArgs>? Quartelyschedule { get; set; }

        /// <summary>
        /// - (Optional) daily snapshot config
        /// </summary>
        [Input("snapshottimeofday")]
        public Input<Inputs.NdbRegisterDatabaseTimeMachineInfoScheduleSnapshottimeofdayArgs>? Snapshottimeofday { get; set; }

        /// <summary>
        /// - (Optional) weekly snapshot config
        /// </summary>
        [Input("weeklyschedule")]
        public Input<Inputs.NdbRegisterDatabaseTimeMachineInfoScheduleWeeklyscheduleArgs>? Weeklyschedule { get; set; }

        /// <summary>
        /// - (Optional) yearly snapshot config
        /// </summary>
        [Input("yearlyschedule")]
        public Input<Inputs.NdbRegisterDatabaseTimeMachineInfoScheduleYearlyscheduleArgs>? Yearlyschedule { get; set; }

        public NdbRegisterDatabaseTimeMachineInfoScheduleArgs()
        {
        }
        public static new NdbRegisterDatabaseTimeMachineInfoScheduleArgs Empty => new NdbRegisterDatabaseTimeMachineInfoScheduleArgs();
    }
}
