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

    public sealed class NdbDatabaseMaintenanceTasksTaskArgs : global::Pulumi.ResourceArgs
    {
        [Input("postCommand")]
        public Input<string>? PostCommand { get; set; }

        [Input("preCommand")]
        public Input<string>? PreCommand { get; set; }

        [Input("taskType")]
        public Input<string>? TaskType { get; set; }

        public NdbDatabaseMaintenanceTasksTaskArgs()
        {
        }
        public static new NdbDatabaseMaintenanceTasksTaskArgs Empty => new NdbDatabaseMaintenanceTasksTaskArgs();
    }
}
