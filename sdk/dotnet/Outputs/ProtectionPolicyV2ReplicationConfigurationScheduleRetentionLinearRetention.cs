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
    public sealed class ProtectionPolicyV2ReplicationConfigurationScheduleRetentionLinearRetention
    {
        /// <summary>
        /// -(Required) Specifies the number of recovery points to retain on the local location.
        /// </summary>
        public readonly int Local;
        /// <summary>
        /// -(Optional) Specifies the number of recovery points to retain on the remote location.
        /// </summary>
        public readonly int? Remote;

        [OutputConstructor]
        private ProtectionPolicyV2ReplicationConfigurationScheduleRetentionLinearRetention(
            int local,

            int? remote)
        {
            Local = local;
            Remote = remote;
        }
    }
}
