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

    public sealed class GetAddressGroupsMetadataInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Optional) Filter in FIQL Syntax
        /// </summary>
        [Input("filter", required: true)]
        public Input<string> Filter { get; set; } = null!;

        [Input("kind", required: true)]
        public Input<string> Kind { get; set; } = null!;

        /// <summary>
        /// (Optional) Integer
        /// </summary>
        [Input("length", required: true)]
        public Input<int> Length { get; set; } = null!;

        /// <summary>
        /// (Optional) Integer
        /// </summary>
        [Input("offset", required: true)]
        public Input<int> Offset { get; set; } = null!;

        /// <summary>
        /// (Optional) attribute to sort
        /// </summary>
        [Input("sortAttribute", required: true)]
        public Input<string> SortAttribute { get; set; } = null!;

        /// <summary>
        /// (Optional) order of sorting
        /// </summary>
        [Input("sortOrder", required: true)]
        public Input<string> SortOrder { get; set; } = null!;

        public GetAddressGroupsMetadataInputArgs()
        {
        }
        public static new GetAddressGroupsMetadataInputArgs Empty => new GetAddressGroupsMetadataInputArgs();
    }
}
