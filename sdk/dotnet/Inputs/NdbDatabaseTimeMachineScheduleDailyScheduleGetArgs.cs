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

    public sealed class NdbDatabaseTimeMachineScheduleDailyScheduleGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public NdbDatabaseTimeMachineScheduleDailyScheduleGetArgs()
        {
        }
        public static new NdbDatabaseTimeMachineScheduleDailyScheduleGetArgs Empty => new NdbDatabaseTimeMachineScheduleDailyScheduleGetArgs();
    }
}
