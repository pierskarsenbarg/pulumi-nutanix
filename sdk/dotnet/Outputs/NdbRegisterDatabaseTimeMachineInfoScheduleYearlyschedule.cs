// *** WARNING: this file was generated by pulumi-language-dotnet. ***
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
    public sealed class NdbRegisterDatabaseTimeMachineInfoScheduleYearlyschedule
    {
        public readonly int Dayofmonth;
        public readonly bool Enabled;
        public readonly string Month;

        [OutputConstructor]
        private NdbRegisterDatabaseTimeMachineInfoScheduleYearlyschedule(
            int dayofmonth,

            bool enabled,

            string month)
        {
            Dayofmonth = dayofmonth;
            Enabled = enabled;
            Month = month;
        }
    }
}
