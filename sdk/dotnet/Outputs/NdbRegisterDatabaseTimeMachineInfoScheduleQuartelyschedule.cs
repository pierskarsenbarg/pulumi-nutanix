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
    public sealed class NdbRegisterDatabaseTimeMachineInfoScheduleQuartelyschedule
    {
        public readonly int Dayofmonth;
        public readonly bool Enabled;
        public readonly string Startmonth;

        [OutputConstructor]
        private NdbRegisterDatabaseTimeMachineInfoScheduleQuartelyschedule(
            int dayofmonth,

            bool enabled,

            string startmonth)
        {
            Dayofmonth = dayofmonth;
            Enabled = enabled;
            Startmonth = startmonth;
        }
    }
}