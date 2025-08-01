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

    public sealed class NdbDbserverVmMaintenanceTasksArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Associate an existing maintenance window id. NDB starts OS patching or database patching as per the schedule defined in the maintenance window.
        /// </summary>
        [Input("maintenanceWindowId")]
        public Input<string>? MaintenanceWindowId { get; set; }

        [Input("tasks")]
        private InputList<Inputs.NdbDbserverVmMaintenanceTasksTaskArgs>? _tasks;

        /// <summary>
        /// Tasks for the maintenance.
        /// * `tasks.task_type`: use this option if you want NDB to perform database patching or OS patching automatically. Supports [ OS_PATCHING, DB_PATCHING ].
        /// * `tasks.pre_command`: add pre (operating system and database patching) commands.
        /// * `tasks.post_command`:add post (operating system and database patching) commands.
        /// </summary>
        public InputList<Inputs.NdbDbserverVmMaintenanceTasksTaskArgs> Tasks
        {
            get => _tasks ?? (_tasks = new InputList<Inputs.NdbDbserverVmMaintenanceTasksTaskArgs>());
            set => _tasks = value;
        }

        public NdbDbserverVmMaintenanceTasksArgs()
        {
        }
        public static new NdbDbserverVmMaintenanceTasksArgs Empty => new NdbDbserverVmMaintenanceTasksArgs();
    }
}
