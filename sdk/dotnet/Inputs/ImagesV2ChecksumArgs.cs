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

    public sealed class ImagesV2ChecksumArgs : global::Pulumi.ResourceArgs
    {
        [Input("hexDigest", required: true)]
        public Input<string> HexDigest { get; set; } = null!;

        [Input("objectType", required: true)]
        public Input<string> ObjectType { get; set; } = null!;

        public ImagesV2ChecksumArgs()
        {
        }
        public static new ImagesV2ChecksumArgs Empty => new ImagesV2ChecksumArgs();
    }
}
