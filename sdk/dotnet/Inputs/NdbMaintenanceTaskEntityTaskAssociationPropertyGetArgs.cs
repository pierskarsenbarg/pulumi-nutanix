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

    public sealed class NdbMaintenanceTaskEntityTaskAssociationPropertyGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// name of of maintenance window
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        public NdbMaintenanceTaskEntityTaskAssociationPropertyGetArgs()
        {
        }
        public static new NdbMaintenanceTaskEntityTaskAssociationPropertyGetArgs Empty => new NdbMaintenanceTaskEntityTaskAssociationPropertyGetArgs();
    }
}
