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
    public sealed class GetImagesV2ImageSourceUrlSourceResult
    {
        public readonly ImmutableArray<Outputs.GetImagesV2ImageSourceUrlSourceBasicAuthResult> BasicAuths;
        public readonly bool ShouldAllowInsecureUrl;
        public readonly string Url;

        [OutputConstructor]
        private GetImagesV2ImageSourceUrlSourceResult(
            ImmutableArray<Outputs.GetImagesV2ImageSourceUrlSourceBasicAuthResult> basicAuths,

            bool shouldAllowInsecureUrl,

            string url)
        {
            BasicAuths = basicAuths;
            ShouldAllowInsecureUrl = shouldAllowInsecureUrl;
            Url = url;
        }
    }
}
