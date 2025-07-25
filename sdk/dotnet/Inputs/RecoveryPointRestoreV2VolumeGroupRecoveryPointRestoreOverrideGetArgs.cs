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

    public sealed class RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("volumeGroupOverrideSpecs")]
        private InputList<Inputs.RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideVolumeGroupOverrideSpecGetArgs>? _volumeGroupOverrideSpecs;

        /// <summary>
        /// -(Optional) Protected resource/recovery point restore that overrides the volume group configuration. The specified properties will be overridden for the restored volume group.
        /// </summary>
        public InputList<Inputs.RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideVolumeGroupOverrideSpecGetArgs> VolumeGroupOverrideSpecs
        {
            get => _volumeGroupOverrideSpecs ?? (_volumeGroupOverrideSpecs = new InputList<Inputs.RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideVolumeGroupOverrideSpecGetArgs>());
            set => _volumeGroupOverrideSpecs = value;
        }

        /// <summary>
        /// -(Required) External identifier of a volume group recovery point, that is a part of the top-level recovery point.
        /// </summary>
        [Input("volumeGroupRecoveryPointExtId", required: true)]
        public Input<string> VolumeGroupRecoveryPointExtId { get; set; } = null!;

        public RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideGetArgs()
        {
        }
        public static new RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideGetArgs Empty => new RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideGetArgs();
    }
}
