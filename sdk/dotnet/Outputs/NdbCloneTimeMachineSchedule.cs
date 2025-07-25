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
    public sealed class NdbCloneTimeMachineSchedule
    {
        public readonly ImmutableArray<Outputs.NdbCloneTimeMachineScheduleContinuousSchedule> ContinuousSchedules;
        public readonly ImmutableArray<Outputs.NdbCloneTimeMachineScheduleDailySchedule> DailySchedules;
        /// <summary>
        /// date created for clone
        /// </summary>
        public readonly string? DateCreated;
        /// <summary>
        /// last modified date for clone
        /// </summary>
        public readonly string? DateModified;
        /// <summary>
        /// database instance description
        /// </summary>
        public readonly string? Description;
        public readonly bool? GlobalPolicy;
        public readonly string? Id;
        public readonly ImmutableArray<Outputs.NdbCloneTimeMachineScheduleMonthlySchedule> MonthlySchedules;
        /// <summary>
        /// database instance name
        /// </summary>
        public readonly string? Name;
        public readonly string? OwnerId;
        public readonly ImmutableArray<Outputs.NdbCloneTimeMachineScheduleQuartelySchedule> QuartelySchedules;
        public readonly int? ReferenceCount;
        public readonly ImmutableArray<Outputs.NdbCloneTimeMachineScheduleSnapshotTimeOfDay> SnapshotTimeOfDays;
        public readonly string? StartTime;
        public readonly bool? SystemPolicy;
        /// <summary>
        /// timezone
        /// </summary>
        public readonly string? TimeZone;
        public readonly string? UniqueName;
        public readonly ImmutableArray<Outputs.NdbCloneTimeMachineScheduleWeeklySchedule> WeeklySchedules;
        public readonly ImmutableArray<Outputs.NdbCloneTimeMachineScheduleYearlySchedule> YearlySchedules;

        [OutputConstructor]
        private NdbCloneTimeMachineSchedule(
            ImmutableArray<Outputs.NdbCloneTimeMachineScheduleContinuousSchedule> continuousSchedules,

            ImmutableArray<Outputs.NdbCloneTimeMachineScheduleDailySchedule> dailySchedules,

            string? dateCreated,

            string? dateModified,

            string? description,

            bool? globalPolicy,

            string? id,

            ImmutableArray<Outputs.NdbCloneTimeMachineScheduleMonthlySchedule> monthlySchedules,

            string? name,

            string? ownerId,

            ImmutableArray<Outputs.NdbCloneTimeMachineScheduleQuartelySchedule> quartelySchedules,

            int? referenceCount,

            ImmutableArray<Outputs.NdbCloneTimeMachineScheduleSnapshotTimeOfDay> snapshotTimeOfDays,

            string? startTime,

            bool? systemPolicy,

            string? timeZone,

            string? uniqueName,

            ImmutableArray<Outputs.NdbCloneTimeMachineScheduleWeeklySchedule> weeklySchedules,

            ImmutableArray<Outputs.NdbCloneTimeMachineScheduleYearlySchedule> yearlySchedules)
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
