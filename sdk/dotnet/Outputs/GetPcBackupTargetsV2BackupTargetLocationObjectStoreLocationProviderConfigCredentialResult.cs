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
    public sealed class GetPcBackupTargetsV2BackupTargetLocationObjectStoreLocationProviderConfigCredentialResult
    {
        public readonly string AccessKeyId;
        public readonly string SecretAccessKey;

        [OutputConstructor]
        private GetPcBackupTargetsV2BackupTargetLocationObjectStoreLocationProviderConfigCredentialResult(
            string accessKeyId,

            string secretAccessKey)
        {
            AccessKeyId = accessKeyId;
            SecretAccessKey = secretAccessKey;
        }
    }
}
