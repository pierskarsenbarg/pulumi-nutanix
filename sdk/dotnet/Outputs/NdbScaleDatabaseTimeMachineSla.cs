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
    public sealed class NdbScaleDatabaseTimeMachineSla
    {
        public readonly int? ContinuousRetention;
        public readonly string? CurrentActiveFrequency;
        public readonly int? DailyRetention;
        /// <summary>
        /// date created for db instance
        /// </summary>
        public readonly string? DateCreated;
        /// <summary>
        /// date modified for instance
        /// </summary>
        public readonly string? DateModified;
        /// <summary>
        /// description of database instance
        /// </summary>
        public readonly string? Description;
        public readonly string? Id;
        public readonly int? MonthlyRetention;
        /// <summary>
        /// Name of database instance
        /// </summary>
        public readonly string? Name;
        public readonly string? OwnerId;
        public readonly bool? PitrEnabled;
        public readonly int? QuarterlyRetention;
        public readonly int? ReferenceCount;
        public readonly bool? SystemSla;
        public readonly string? UniqueName;
        public readonly int? WeeklyRetention;
        public readonly int? YearlyRetention;

        [OutputConstructor]
        private NdbScaleDatabaseTimeMachineSla(
            int? continuousRetention,

            string? currentActiveFrequency,

            int? dailyRetention,

            string? dateCreated,

            string? dateModified,

            string? description,

            string? id,

            int? monthlyRetention,

            string? name,

            string? ownerId,

            bool? pitrEnabled,

            int? quarterlyRetention,

            int? referenceCount,

            bool? systemSla,

            string? uniqueName,

            int? weeklyRetention,

            int? yearlyRetention)
        {
            ContinuousRetention = continuousRetention;
            CurrentActiveFrequency = currentActiveFrequency;
            DailyRetention = dailyRetention;
            DateCreated = dateCreated;
            DateModified = dateModified;
            Description = description;
            Id = id;
            MonthlyRetention = monthlyRetention;
            Name = name;
            OwnerId = ownerId;
            PitrEnabled = pitrEnabled;
            QuarterlyRetention = quarterlyRetention;
            ReferenceCount = referenceCount;
            SystemSla = systemSla;
            UniqueName = uniqueName;
            WeeklyRetention = weeklyRetention;
            YearlyRetention = yearlyRetention;
        }
    }
}
