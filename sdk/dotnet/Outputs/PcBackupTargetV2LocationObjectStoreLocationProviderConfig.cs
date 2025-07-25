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
    public sealed class PcBackupTargetV2LocationObjectStoreLocationProviderConfig
    {
        /// <summary>
        /// -(Required) The bucket name of the object store endpoint where backup data of domain manager is to be stored.
        /// </summary>
        public readonly string BucketName;
        /// <summary>
        /// -(Optional) Secret credentials model for the object store containing access key ID and secret access key.
        /// </summary>
        public readonly Outputs.PcBackupTargetV2LocationObjectStoreLocationProviderConfigCredentials? Credentials;
        /// <summary>
        /// -(Optional) The region name of the object store endpoint where backup data of domain manager is stored. Default is `us-east-1`.
        /// </summary>
        public readonly string? Region;

        [OutputConstructor]
        private PcBackupTargetV2LocationObjectStoreLocationProviderConfig(
            string bucketName,

            Outputs.PcBackupTargetV2LocationObjectStoreLocationProviderConfigCredentials? credentials,

            string? region)
        {
            BucketName = bucketName;
            Credentials = credentials;
            Region = region;
        }
    }
}
