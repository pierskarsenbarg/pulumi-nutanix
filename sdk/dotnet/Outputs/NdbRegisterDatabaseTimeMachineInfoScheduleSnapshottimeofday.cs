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
    public sealed class NdbRegisterDatabaseTimeMachineInfoScheduleSnapshottimeofday
    {
        public readonly int Hours;
        public readonly int Minutes;
        public readonly int Seconds;

        [OutputConstructor]
        private NdbRegisterDatabaseTimeMachineInfoScheduleSnapshottimeofday(
            int hours,

            int minutes,

            int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}