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
    public sealed class NdbDbserverVmMaintenanceTasksTask
    {
        public readonly string? PostCommand;
        public readonly string? PreCommand;
        public readonly string? TaskType;

        [OutputConstructor]
        private NdbDbserverVmMaintenanceTasksTask(
            string? postCommand,

            string? preCommand,

            string? taskType)
        {
            PostCommand = postCommand;
            PreCommand = preCommand;
            TaskType = taskType;
        }
    }
}
