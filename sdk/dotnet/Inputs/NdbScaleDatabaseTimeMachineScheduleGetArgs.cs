// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class NdbScaleDatabaseTimeMachineScheduleGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("continuousSchedules")]
        private InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleContinuousScheduleGetArgs>? _continuousSchedules;
        public InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleContinuousScheduleGetArgs> ContinuousSchedules
        {
            get => _continuousSchedules ?? (_continuousSchedules = new InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleContinuousScheduleGetArgs>());
            set => _continuousSchedules = value;
        }

        [Input("dailySchedules")]
        private InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleDailyScheduleGetArgs>? _dailySchedules;
        public InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleDailyScheduleGetArgs> DailySchedules
        {
            get => _dailySchedules ?? (_dailySchedules = new InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleDailyScheduleGetArgs>());
            set => _dailySchedules = value;
        }

        [Input("dateCreated")]
        public Input<string>? DateCreated { get; set; }

        [Input("dateModified")]
        public Input<string>? DateModified { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("globalPolicy")]
        public Input<bool>? GlobalPolicy { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("monthlySchedules")]
        private InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleMonthlyScheduleGetArgs>? _monthlySchedules;
        public InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleMonthlyScheduleGetArgs> MonthlySchedules
        {
            get => _monthlySchedules ?? (_monthlySchedules = new InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleMonthlyScheduleGetArgs>());
            set => _monthlySchedules = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("ownerId")]
        public Input<string>? OwnerId { get; set; }

        [Input("quartelySchedules")]
        private InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleQuartelyScheduleGetArgs>? _quartelySchedules;
        public InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleQuartelyScheduleGetArgs> QuartelySchedules
        {
            get => _quartelySchedules ?? (_quartelySchedules = new InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleQuartelyScheduleGetArgs>());
            set => _quartelySchedules = value;
        }

        [Input("referenceCount")]
        public Input<int>? ReferenceCount { get; set; }

        [Input("snapshotTimeOfDays")]
        private InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleSnapshotTimeOfDayGetArgs>? _snapshotTimeOfDays;
        public InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleSnapshotTimeOfDayGetArgs> SnapshotTimeOfDays
        {
            get => _snapshotTimeOfDays ?? (_snapshotTimeOfDays = new InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleSnapshotTimeOfDayGetArgs>());
            set => _snapshotTimeOfDays = value;
        }

        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        [Input("systemPolicy")]
        public Input<bool>? SystemPolicy { get; set; }

        [Input("timeZone")]
        public Input<string>? TimeZone { get; set; }

        [Input("uniqueName")]
        public Input<string>? UniqueName { get; set; }

        [Input("weeklySchedules")]
        private InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleWeeklyScheduleGetArgs>? _weeklySchedules;
        public InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleWeeklyScheduleGetArgs> WeeklySchedules
        {
            get => _weeklySchedules ?? (_weeklySchedules = new InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleWeeklyScheduleGetArgs>());
            set => _weeklySchedules = value;
        }

        [Input("yearlySchedules")]
        private InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleYearlyScheduleGetArgs>? _yearlySchedules;
        public InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleYearlyScheduleGetArgs> YearlySchedules
        {
            get => _yearlySchedules ?? (_yearlySchedules = new InputList<Inputs.NdbScaleDatabaseTimeMachineScheduleYearlyScheduleGetArgs>());
            set => _yearlySchedules = value;
        }

        public NdbScaleDatabaseTimeMachineScheduleGetArgs()
        {
        }
        public static new NdbScaleDatabaseTimeMachineScheduleGetArgs Empty => new NdbScaleDatabaseTimeMachineScheduleGetArgs();
    }
}