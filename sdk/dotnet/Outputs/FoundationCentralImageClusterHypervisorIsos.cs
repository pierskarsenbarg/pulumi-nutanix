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
    public sealed class FoundationCentralImageClusterHypervisorIsos
    {
        /// <summary>
        /// Product key for hyperv isos. Required only if the hypervisor type is hyperv and product key is mandatory (ex: for volume license).
        /// </summary>
        public readonly string? HypervProductKey;
        /// <summary>
        /// SKU of hyperv to be installed if hypervisor_type is hyperv.
        /// </summary>
        public readonly string? HypervSku;
        public readonly string? HypervisorType;
        /// <summary>
        /// sha256sum of the hypervisor iso.
        /// </summary>
        public readonly string? Sha256sum;
        /// <summary>
        /// URL to download hypervisor iso. Required only if imaging is needed.
        /// </summary>
        public readonly string? Url;

        [OutputConstructor]
        private FoundationCentralImageClusterHypervisorIsos(
            string? hypervProductKey,

            string? hypervSku,

            string? hypervisorType,

            string? sha256sum,

            string? url)
        {
            HypervProductKey = hypervProductKey;
            HypervSku = hypervSku;
            HypervisorType = hypervisorType;
            Sha256sum = sha256sum;
            Url = url;
        }
    }
}
