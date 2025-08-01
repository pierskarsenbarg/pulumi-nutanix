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
    public sealed class PcBackupTargetV2LocationObjectStoreLocationBackupPolicy
    {
        /// <summary>
        /// -(Required) RPO interval in minutes at which the backup will be taken. The Value should be in the range of 60 to 1440.
        /// 
        /// See detailed information in [Nutanix Create Backup Target V4](https://developers.nutanix.com/api-reference?namespace=prism&amp;version=v4.0#tag/DomainManager/operation/createBackupTarget).
        /// </summary>
        public readonly int RpoInMinutes;

        [OutputConstructor]
        private PcBackupTargetV2LocationObjectStoreLocationBackupPolicy(int rpoInMinutes)
        {
            RpoInMinutes = rpoInMinutes;
        }
    }
}
