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

    public sealed class RolePermissionReferenceListGetArgs : Pulumi.ResourceArgs
    {
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("uuid", required: true)]
        public Input<string> Uuid { get; set; } = null!;

        public RolePermissionReferenceListGetArgs()
        {
        }
    }
}