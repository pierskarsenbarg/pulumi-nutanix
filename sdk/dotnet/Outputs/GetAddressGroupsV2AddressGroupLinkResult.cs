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
    public sealed class GetAddressGroupsV2AddressGroupLinkResult
    {
        public readonly string Href;
        public readonly string Rel;

        [OutputConstructor]
        private GetAddressGroupsV2AddressGroupLinkResult(
            string href,

            string rel)
        {
            Href = href;
            Rel = rel;
        }
    }
}
