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
    public sealed class TemplateV2TemplateVersionSpecVersionSourceTemplateVersionReferenceOverrideVmConfigNicNetworkInfoIpv4Config
    {
        public readonly ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVersionReferenceOverrideVmConfigNicNetworkInfoIpv4ConfigIpAddress> IpAddresses;
        public readonly ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVersionReferenceOverrideVmConfigNicNetworkInfoIpv4ConfigSecondaryIpAddressList> SecondaryIpAddressLists;
        public readonly bool? ShouldAssignIp;

        [OutputConstructor]
        private TemplateV2TemplateVersionSpecVersionSourceTemplateVersionReferenceOverrideVmConfigNicNetworkInfoIpv4Config(
            ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVersionReferenceOverrideVmConfigNicNetworkInfoIpv4ConfigIpAddress> ipAddresses,

            ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVersionReferenceOverrideVmConfigNicNetworkInfoIpv4ConfigSecondaryIpAddressList> secondaryIpAddressLists,

            bool? shouldAssignIp)
        {
            IpAddresses = ipAddresses;
            SecondaryIpAddressLists = secondaryIpAddressLists;
            ShouldAssignIp = shouldAssignIp;
        }
    }
}
