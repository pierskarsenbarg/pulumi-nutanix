// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class ImagesV2SourceObjectLiteSourceArgs : global::Pulumi.ResourceArgs
    {
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        public ImagesV2SourceObjectLiteSourceArgs()
        {
        }
        public static new ImagesV2SourceObjectLiteSourceArgs Empty => new ImagesV2SourceObjectLiteSourceArgs();
    }
}
