// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class GetFloatingIpV2ExternalSubnetVpcLinkResult
    {
        public readonly string Href;
        public readonly string Rel;

        [OutputConstructor]
        private GetFloatingIpV2ExternalSubnetVpcLinkResult(
            string href,

            string rel)
        {
            Href = href;
            Rel = rel;
        }
    }
}
