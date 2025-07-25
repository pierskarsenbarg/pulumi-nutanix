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

    public sealed class NdbCloneTimeMachineScheduleGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("continuousSchedules")]
        private InputList<Inputs.NdbCloneTimeMachineScheduleContinuousScheduleGetArgs>? _continuousSchedules;
        public InputList<Inputs.NdbCloneTimeMachineScheduleContinuousScheduleGetArgs> ContinuousSchedules
        {
            get => _continuousSchedules ?? (_continuousSchedules = new InputList<Inputs.NdbCloneTimeMachineScheduleContinuousScheduleGetArgs>());
            set => _continuousSchedules = value;
        }

        [Input("dailySchedules")]
        private InputList<Inputs.NdbCloneTimeMachineScheduleDailyScheduleGetArgs>? _dailySchedules;
        public InputList<Inputs.NdbCloneTimeMachineScheduleDailyScheduleGetArgs> DailySchedules
        {
            get => _dailySchedules ?? (_dailySchedules = new InputList<Inputs.NdbCloneTimeMachineScheduleDailyScheduleGetArgs>());
            set => _dailySchedules = value;
        }

        /// <summary>
        /// date created for clone
        /// </summary>
        [Input("dateCreated")]
        public Input<string>? DateCreated { get; set; }

        /// <summary>
        /// last modified date for clone
        /// </summary>
        [Input("dateModified")]
        public Input<string>? DateModified { get; set; }

        /// <summary>
        /// database instance description
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("globalPolicy")]
        public Input<bool>? GlobalPolicy { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("monthlySchedules")]
        private InputList<Inputs.NdbCloneTimeMachineScheduleMonthlyScheduleGetArgs>? _monthlySchedules;
        public InputList<Inputs.NdbCloneTimeMachineScheduleMonthlyScheduleGetArgs> MonthlySchedules
        {
            get => _monthlySchedules ?? (_monthlySchedules = new InputList<Inputs.NdbCloneTimeMachineScheduleMonthlyScheduleGetArgs>());
            set => _monthlySchedules = value;
        }

        /// <summary>
        /// database instance name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("ownerId")]
        public Input<string>? OwnerId { get; set; }

        [Input("quartelySchedules")]
        private InputList<Inputs.NdbCloneTimeMachineScheduleQuartelyScheduleGetArgs>? _quartelySchedules;
        public InputList<Inputs.NdbCloneTimeMachineScheduleQuartelyScheduleGetArgs> QuartelySchedules
        {
            get => _quartelySchedules ?? (_quartelySchedules = new InputList<Inputs.NdbCloneTimeMachineScheduleQuartelyScheduleGetArgs>());
            set => _quartelySchedules = value;
        }

        [Input("referenceCount")]
        public Input<int>? ReferenceCount { get; set; }

        [Input("snapshotTimeOfDays")]
        private InputList<Inputs.NdbCloneTimeMachineScheduleSnapshotTimeOfDayGetArgs>? _snapshotTimeOfDays;
        public InputList<Inputs.NdbCloneTimeMachineScheduleSnapshotTimeOfDayGetArgs> SnapshotTimeOfDays
        {
            get => _snapshotTimeOfDays ?? (_snapshotTimeOfDays = new InputList<Inputs.NdbCloneTimeMachineScheduleSnapshotTimeOfDayGetArgs>());
            set => _snapshotTimeOfDays = value;
        }

        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        [Input("systemPolicy")]
        public Input<bool>? SystemPolicy { get; set; }

        /// <summary>
        /// timezone
        /// </summary>
        [Input("timeZone")]
        public Input<string>? TimeZone { get; set; }

        [Input("uniqueName")]
        public Input<string>? UniqueName { get; set; }

        [Input("weeklySchedules")]
        private InputList<Inputs.NdbCloneTimeMachineScheduleWeeklyScheduleGetArgs>? _weeklySchedules;
        public InputList<Inputs.NdbCloneTimeMachineScheduleWeeklyScheduleGetArgs> WeeklySchedules
        {
            get => _weeklySchedules ?? (_weeklySchedules = new InputList<Inputs.NdbCloneTimeMachineScheduleWeeklyScheduleGetArgs>());
            set => _weeklySchedules = value;
        }

        [Input("yearlySchedules")]
        private InputList<Inputs.NdbCloneTimeMachineScheduleYearlyScheduleGetArgs>? _yearlySchedules;
        public InputList<Inputs.NdbCloneTimeMachineScheduleYearlyScheduleGetArgs> YearlySchedules
        {
            get => _yearlySchedules ?? (_yearlySchedules = new InputList<Inputs.NdbCloneTimeMachineScheduleYearlyScheduleGetArgs>());
            set => _yearlySchedules = value;
        }

        public NdbCloneTimeMachineScheduleGetArgs()
        {
        }
        public static new NdbCloneTimeMachineScheduleGetArgs Empty => new NdbCloneTimeMachineScheduleGetArgs();
    }
}
