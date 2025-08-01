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

    public sealed class VolumeGroupV2DiskDiskDataSourceReferenceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - The Entity Type of the Data Source Reference.
        /// </summary>
        [Input("entityType")]
        public Input<string>? EntityType { get; set; }

        /// <summary>
        /// - The external identifier of the Data Source Reference.
        /// </summary>
        [Input("extId", required: true)]
        public Input<string> ExtId { get; set; } = null!;

        /// <summary>
        /// - The name of the Data Source Reference.bled for the Volume Group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("uris")]
        private InputList<string>? _uris;

        /// <summary>
        /// - The uri list of the Data Source Reference.
        /// </summary>
        public InputList<string> Uris
        {
            get => _uris ?? (_uris = new InputList<string>());
            set => _uris = value;
        }

        public VolumeGroupV2DiskDiskDataSourceReferenceArgs()
        {
        }
        public static new VolumeGroupV2DiskDiskDataSourceReferenceArgs Empty => new VolumeGroupV2DiskDiskDataSourceReferenceArgs();
    }
}
