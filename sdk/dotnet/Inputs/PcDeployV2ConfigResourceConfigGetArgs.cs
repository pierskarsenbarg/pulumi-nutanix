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

    public sealed class PcDeployV2ConfigResourceConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("containerExtIds")]
        private InputList<string>? _containerExtIds;

        /// <summary>
        /// -(Optional) The external identifier of the container that will be used to create the domain manager (Prism Central) cluster.
        /// </summary>
        public InputList<string> ContainerExtIds
        {
            get => _containerExtIds ?? (_containerExtIds = new InputList<string>());
            set => _containerExtIds = value;
        }

        [Input("dataDiskSizeBytes")]
        public Input<int>? DataDiskSizeBytes { get; set; }

        [Input("memorySizeBytes")]
        public Input<int>? MemorySizeBytes { get; set; }

        [Input("numVcpus")]
        public Input<int>? NumVcpus { get; set; }

        public PcDeployV2ConfigResourceConfigGetArgs()
        {
        }
        public static new PcDeployV2ConfigResourceConfigGetArgs Empty => new PcDeployV2ConfigResourceConfigGetArgs();
    }
}
