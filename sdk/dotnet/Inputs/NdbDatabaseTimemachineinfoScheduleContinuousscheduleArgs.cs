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

    public sealed class NdbDatabaseTimemachineinfoScheduleContinuousscheduleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - (Required) to enable
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// - (Required) log catchup interval for database
        /// </summary>
        [Input("logbackupinterval", required: true)]
        public Input<int> Logbackupinterval { get; set; } = null!;

        /// <summary>
        /// - (Required) num of snapshots per day
        /// </summary>
        [Input("snapshotsperday", required: true)]
        public Input<int> Snapshotsperday { get; set; } = null!;

        public NdbDatabaseTimemachineinfoScheduleContinuousscheduleArgs()
        {
        }
        public static new NdbDatabaseTimemachineinfoScheduleContinuousscheduleArgs Empty => new NdbDatabaseTimemachineinfoScheduleContinuousscheduleArgs();
    }
}
