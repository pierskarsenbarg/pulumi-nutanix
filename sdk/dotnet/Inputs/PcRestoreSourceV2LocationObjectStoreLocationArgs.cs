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

    public sealed class PcRestoreSourceV2LocationObjectStoreLocationArgs : global::Pulumi.ResourceArgs
    {
        [Input("backupPolicies")]
        private InputList<Inputs.PcRestoreSourceV2LocationObjectStoreLocationBackupPolicyArgs>? _backupPolicies;

        /// <summary>
        /// -(Optional) Backup policy for the object store provided.
        /// </summary>
        public InputList<Inputs.PcRestoreSourceV2LocationObjectStoreLocationBackupPolicyArgs> BackupPolicies
        {
            get => _backupPolicies ?? (_backupPolicies = new InputList<Inputs.PcRestoreSourceV2LocationObjectStoreLocationBackupPolicyArgs>());
            set => _backupPolicies = value;
        }

        [Input("providerConfigs", required: true)]
        private InputList<Inputs.PcRestoreSourceV2LocationObjectStoreLocationProviderConfigArgs>? _providerConfigs;

        /// <summary>
        /// -(Required) The base model of S3 object store endpoint where domain manager is backed up.
        /// </summary>
        public InputList<Inputs.PcRestoreSourceV2LocationObjectStoreLocationProviderConfigArgs> ProviderConfigs
        {
            get => _providerConfigs ?? (_providerConfigs = new InputList<Inputs.PcRestoreSourceV2LocationObjectStoreLocationProviderConfigArgs>());
            set => _providerConfigs = value;
        }

        public PcRestoreSourceV2LocationObjectStoreLocationArgs()
        {
        }
        public static new PcRestoreSourceV2LocationObjectStoreLocationArgs Empty => new PcRestoreSourceV2LocationObjectStoreLocationArgs();
    }
}
