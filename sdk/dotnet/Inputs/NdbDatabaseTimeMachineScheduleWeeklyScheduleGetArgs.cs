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

    public sealed class NdbDatabaseTimeMachineScheduleWeeklyScheduleGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("dayOfWeek")]
        public Input<string>? DayOfWeek { get; set; }

        [Input("dayOfWeekValue")]
        public Input<string>? DayOfWeekValue { get; set; }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public NdbDatabaseTimeMachineScheduleWeeklyScheduleGetArgs()
        {
        }
        public static new NdbDatabaseTimeMachineScheduleWeeklyScheduleGetArgs Empty => new NdbDatabaseTimeMachineScheduleWeeklyScheduleGetArgs();
    }
}
