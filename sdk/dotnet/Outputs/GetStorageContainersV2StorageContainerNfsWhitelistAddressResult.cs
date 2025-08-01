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
    public sealed class GetStorageContainersV2StorageContainerNfsWhitelistAddressResult
    {
        public readonly ImmutableArray<Outputs.GetStorageContainersV2StorageContainerNfsWhitelistAddressFqdnResult> Fqdns;
        public readonly ImmutableArray<Outputs.GetStorageContainersV2StorageContainerNfsWhitelistAddressIpv4Result> Ipv4s;
        public readonly ImmutableArray<Outputs.GetStorageContainersV2StorageContainerNfsWhitelistAddressIpv6Result> Ipv6s;

        [OutputConstructor]
        private GetStorageContainersV2StorageContainerNfsWhitelistAddressResult(
            ImmutableArray<Outputs.GetStorageContainersV2StorageContainerNfsWhitelistAddressFqdnResult> fqdns,

            ImmutableArray<Outputs.GetStorageContainersV2StorageContainerNfsWhitelistAddressIpv4Result> ipv4s,

            ImmutableArray<Outputs.GetStorageContainersV2StorageContainerNfsWhitelistAddressIpv6Result> ipv6s)
        {
            Fqdns = fqdns;
            Ipv4s = ipv4s;
            Ipv6s = ipv6s;
        }
    }
}
