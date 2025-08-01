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
    public sealed class GetHostsV2HostEntityKeyManagementDeviceToCertStatusResult
    {
        public readonly bool IsCertificatePresent;
        public readonly string KeyManagementServerName;

        [OutputConstructor]
        private GetHostsV2HostEntityKeyManagementDeviceToCertStatusResult(
            bool isCertificatePresent,

            string keyManagementServerName)
        {
            IsCertificatePresent = isCertificatePresent;
            KeyManagementServerName = keyManagementServerName;
        }
    }
}
