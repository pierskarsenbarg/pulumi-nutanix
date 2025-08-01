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
    public sealed class ImagesV2SourceUrlSource
    {
        public readonly ImmutableArray<Outputs.ImagesV2SourceUrlSourceBasicAuth> BasicAuths;
        public readonly bool? ShouldAllowInsecureUrl;
        public readonly string Url;

        [OutputConstructor]
        private ImagesV2SourceUrlSource(
            ImmutableArray<Outputs.ImagesV2SourceUrlSourceBasicAuth> basicAuths,

            bool? shouldAllowInsecureUrl,

            string url)
        {
            BasicAuths = basicAuths;
            ShouldAllowInsecureUrl = shouldAllowInsecureUrl;
            Url = url;
        }
    }
}
