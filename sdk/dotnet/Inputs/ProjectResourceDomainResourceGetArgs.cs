// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class ProjectResourceDomainResourceGetArgs : Pulumi.ResourceArgs
    {
        [Input("limit", required: true)]
        public Input<int> Limit { get; set; } = null!;

        [Input("resourceType", required: true)]
        public Input<string> ResourceType { get; set; } = null!;

        [Input("units")]
        public Input<string>? Units { get; set; }

        /// <summary>
        /// value of the key.
        /// </summary>
        [Input("value")]
        public Input<int>? Value { get; set; }

        public ProjectResourceDomainResourceGetArgs()
        {
        }
    }
}