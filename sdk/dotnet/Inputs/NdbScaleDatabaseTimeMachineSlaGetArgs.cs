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

    public sealed class NdbScaleDatabaseTimeMachineSlaGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("continuousRetention")]
        public Input<int>? ContinuousRetention { get; set; }

        [Input("currentActiveFrequency")]
        public Input<string>? CurrentActiveFrequency { get; set; }

        [Input("dailyRetention")]
        public Input<int>? DailyRetention { get; set; }

        /// <summary>
        /// date created for db instance
        /// </summary>
        [Input("dateCreated")]
        public Input<string>? DateCreated { get; set; }

        /// <summary>
        /// date modified for instance
        /// </summary>
        [Input("dateModified")]
        public Input<string>? DateModified { get; set; }

        /// <summary>
        /// description of database instance
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("monthlyRetention")]
        public Input<int>? MonthlyRetention { get; set; }

        /// <summary>
        /// Name of database instance
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("ownerId")]
        public Input<string>? OwnerId { get; set; }

        [Input("pitrEnabled")]
        public Input<bool>? PitrEnabled { get; set; }

        [Input("quarterlyRetention")]
        public Input<int>? QuarterlyRetention { get; set; }

        [Input("referenceCount")]
        public Input<int>? ReferenceCount { get; set; }

        [Input("systemSla")]
        public Input<bool>? SystemSla { get; set; }

        [Input("uniqueName")]
        public Input<string>? UniqueName { get; set; }

        [Input("weeklyRetention")]
        public Input<int>? WeeklyRetention { get; set; }

        [Input("yearlyRetention")]
        public Input<int>? YearlyRetention { get; set; }

        public NdbScaleDatabaseTimeMachineSlaGetArgs()
        {
        }
        public static new NdbScaleDatabaseTimeMachineSlaGetArgs Empty => new NdbScaleDatabaseTimeMachineSlaGetArgs();
    }
}
