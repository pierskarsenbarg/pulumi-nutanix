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
    public sealed class NdbDatabaseScaleTimeMachineSchedule
    {
        public readonly ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleContinuousSchedule> ContinuousSchedules;
        public readonly ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleDailySchedule> DailySchedules;
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
        public readonly bool? GlobalPolicy;
        public readonly string? Id;
        public readonly ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleMonthlySchedule> MonthlySchedules;
        /// <summary>
        /// Name of database instance
        /// </summary>
        public readonly string? Name;
        public readonly string? OwnerId;
        public readonly ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleQuartelySchedule> QuartelySchedules;
        public readonly int? ReferenceCount;
        public readonly ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleSnapshotTimeOfDay> SnapshotTimeOfDays;
        public readonly string? StartTime;
        public readonly bool? SystemPolicy;
        /// <summary>
        /// timezone on which instance is created xw
        /// </summary>
        public readonly string? TimeZone;
        public readonly string? UniqueName;
        public readonly ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleWeeklySchedule> WeeklySchedules;
        public readonly ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleYearlySchedule> YearlySchedules;

        [OutputConstructor]
        private NdbDatabaseScaleTimeMachineSchedule(
            ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleContinuousSchedule> continuousSchedules,

            ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleDailySchedule> dailySchedules,

            string? dateCreated,

            string? dateModified,

            string? description,

            bool? globalPolicy,

            string? id,

            ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleMonthlySchedule> monthlySchedules,

            string? name,

            string? ownerId,

            ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleQuartelySchedule> quartelySchedules,

            int? referenceCount,

            ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleSnapshotTimeOfDay> snapshotTimeOfDays,

            string? startTime,

            bool? systemPolicy,

            string? timeZone,

            string? uniqueName,

            ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleWeeklySchedule> weeklySchedules,

            ImmutableArray<Outputs.NdbDatabaseScaleTimeMachineScheduleYearlySchedule> yearlySchedules)
        {
            ContinuousSchedules = continuousSchedules;
            DailySchedules = dailySchedules;
            DateCreated = dateCreated;
            DateModified = dateModified;
            Description = description;
            GlobalPolicy = globalPolicy;
            Id = id;
            MonthlySchedules = monthlySchedules;
            Name = name;
            OwnerId = ownerId;
            QuartelySchedules = quartelySchedules;
            ReferenceCount = referenceCount;
            SnapshotTimeOfDays = snapshotTimeOfDays;
            StartTime = startTime;
            SystemPolicy = systemPolicy;
            TimeZone = timeZone;
            UniqueName = uniqueName;
            WeeklySchedules = weeklySchedules;
            YearlySchedules = yearlySchedules;
        }
    }
}
