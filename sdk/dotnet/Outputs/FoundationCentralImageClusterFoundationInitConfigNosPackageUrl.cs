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
    public sealed class FoundationCentralImageClusterFoundationInitConfigNosPackageUrl
    {
        /// <summary>
        /// sha256sum of the hypervisor iso.
        /// </summary>
        public readonly string? Sha256sum;
        /// <summary>
        /// URL to download hypervisor iso. Required only if imaging is needed.
        /// </summary>
        public readonly string? Url;

        [OutputConstructor]
        private FoundationCentralImageClusterFoundationInitConfigNosPackageUrl(
            string? sha256sum,

            string? url)
        {
            Sha256sum = sha256sum;
            Url = url;
        }
    }
}
