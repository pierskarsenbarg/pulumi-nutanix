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

    public sealed class NdbDatabaseRestoreTimeMachineScheduleArgs : global::Pulumi.ResourceArgs
    {
        [Input("continuousSchedules")]
        private InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleContinuousScheduleArgs>? _continuousSchedules;
        public InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleContinuousScheduleArgs> ContinuousSchedules
        {
            get => _continuousSchedules ?? (_continuousSchedules = new InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleContinuousScheduleArgs>());
            set => _continuousSchedules = value;
        }

        [Input("dailySchedules")]
        private InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleDailyScheduleArgs>? _dailySchedules;
        public InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleDailyScheduleArgs> DailySchedules
        {
            get => _dailySchedules ?? (_dailySchedules = new InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleDailyScheduleArgs>());
            set => _dailySchedules = value;
        }

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

        [Input("globalPolicy")]
        public Input<bool>? GlobalPolicy { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("monthlySchedules")]
        private InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleMonthlyScheduleArgs>? _monthlySchedules;
        public InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleMonthlyScheduleArgs> MonthlySchedules
        {
            get => _monthlySchedules ?? (_monthlySchedules = new InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleMonthlyScheduleArgs>());
            set => _monthlySchedules = value;
        }

        /// <summary>
        /// Name of database instance
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("ownerId")]
        public Input<string>? OwnerId { get; set; }

        [Input("quartelySchedules")]
        private InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleQuartelyScheduleArgs>? _quartelySchedules;
        public InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleQuartelyScheduleArgs> QuartelySchedules
        {
            get => _quartelySchedules ?? (_quartelySchedules = new InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleQuartelyScheduleArgs>());
            set => _quartelySchedules = value;
        }

        [Input("referenceCount")]
        public Input<int>? ReferenceCount { get; set; }

        [Input("snapshotTimeOfDays")]
        private InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleSnapshotTimeOfDayArgs>? _snapshotTimeOfDays;
        public InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleSnapshotTimeOfDayArgs> SnapshotTimeOfDays
        {
            get => _snapshotTimeOfDays ?? (_snapshotTimeOfDays = new InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleSnapshotTimeOfDayArgs>());
            set => _snapshotTimeOfDays = value;
        }

        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        [Input("systemPolicy")]
        public Input<bool>? SystemPolicy { get; set; }

        /// <summary>
        /// timezone on which instance is created xw
        /// </summary>
        [Input("timeZone")]
        public Input<string>? TimeZone { get; set; }

        [Input("uniqueName")]
        public Input<string>? UniqueName { get; set; }

        [Input("weeklySchedules")]
        private InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleWeeklyScheduleArgs>? _weeklySchedules;
        public InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleWeeklyScheduleArgs> WeeklySchedules
        {
            get => _weeklySchedules ?? (_weeklySchedules = new InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleWeeklyScheduleArgs>());
            set => _weeklySchedules = value;
        }

        [Input("yearlySchedules")]
        private InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleYearlyScheduleArgs>? _yearlySchedules;
        public InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleYearlyScheduleArgs> YearlySchedules
        {
            get => _yearlySchedules ?? (_yearlySchedules = new InputList<Inputs.NdbDatabaseRestoreTimeMachineScheduleYearlyScheduleArgs>());
            set => _yearlySchedules = value;
        }

        public NdbDatabaseRestoreTimeMachineScheduleArgs()
        {
        }
        public static new NdbDatabaseRestoreTimeMachineScheduleArgs Empty => new NdbDatabaseRestoreTimeMachineScheduleArgs();
    }
}
